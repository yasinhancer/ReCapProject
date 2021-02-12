﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;

namespace Core.Utilities.Concrete
{
    public class Result : IResult
    {
        public Result(bool success,string message): this(success) //this: aşağıdaki succes buradaki success'tir(bağlantı)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
