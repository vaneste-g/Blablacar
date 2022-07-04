using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Appblacar.ViewModels
{
    public class ViajeViewModel : BaseViewModel
    {
        // Commandos
        // private Command _SaveCommand;
        //public Command SaveCommand => _SaveCommand ?? (_SaveCommand = new Command(SaveAction));

        //private Command _DeleteCommand;
        //public Command DeleteCommand => DeleteCommand ?? (_DeleteCommand = new Command(DeleteAction));

        //private Command _CancelCommand;
        //public Command CancelCommand => _CancelCommand ?? (_CancelCommand = new Command(CancelAction));

        //Localización
        private Command _GetLocationCommand;
        public Command GetLocationCommand => _GetLocationCommand ?? (_GetLocationCommand = new Command(GetLocationAction));

        //Cámara
        // private Command _TakePictureCommand;
        //public Command TakePictureCommand => _TakePictureCommand ?? (_TakePictureCommand = new Command(TakePictureAction));

        //private Command _SelectPictureCommand;
        //public Command SelectPictureCommand => _SelectPictureCommand ?? (_SelectPictureCommand = new Command(SelectPictureAction));
        // Propiedades

        //Localización
        private double _latitude;
        public double Latitude
        {
            get => _latitude;
            set => SetProperty(ref _latitude, value);
        }

        private double _longitude;
        public double Longitude
        {
            get => _longitude;
            set => SetProperty(ref _longitude, value);
        }

        //Cámara
        // private string _Picture;
        //public string Picture
        //{
        //  get => _Picture;
        //set => SetProperty(ref _Picture, value);
        //}

        // Constructor


        public ViajeViewModel()
        { }

        // Métodos
        private async void GetLocationAction()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                    Latitude = location.Latitude;
                    Longitude = location.Longitude;

                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
        //Cámara 
       //* private async void TakePictureAction()
        //{
            //Inicialización de cámara 
            // await CrossMedia.Current.Initialize();

            //Si la cámara no esta disponioble o soportada lanza mensaje
          //  if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            //{
              //  await Application.Current.MainPage.DisplayAlert("No Camera", ":( No camera available.", "OK");
                //return;
            //}

            //Toma fotográfia y regresa en el objeto file
            //var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            //{
              //  Directory = "FotosViajes",
               // Name = "cam_fotos.jpg"
            //});

            //Si el objeto file es null termina método
            //if (file == null)
              //  return;
            // Se asigna la ruta de la fotografía en la propiedad de la imagen
            //Picture = file.Path;

        //}

        //private async void SelectPictureAction()
        //{
            //Inicialización de cámara 
          //  await CrossMedia.Current.Initialize();

            //Si la selección de fotos no esta disponioble o soportada lanza mensaje
            //if (!CrossMedia.Current.IsPickPhotoSupported)
            //{
              //  await Application.Current.MainPage.DisplayAlert("No Pick Photo", ":( No pick photo available.", "OK");
                //return;
            //}

            //Selecciona la fotográfia y regresa en el objeto file
            //var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            //{
              //  PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium
            //});

            //Si el objeto file es null termina método
            //if (file == null)
               // return;
            // Se asigna la ruta de la fotografía en la propiedad de la imagen
          //  Picture = file.Path;

        //}

        //private void SaveAction(object obj)
        //{
            
        //}
        private void DeleteAction(object obj)
        {
            
        }
        private async void CancelAction(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
