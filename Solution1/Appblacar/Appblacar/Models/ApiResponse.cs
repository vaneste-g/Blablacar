﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Appblacar.Models
{
    public class ApiResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
