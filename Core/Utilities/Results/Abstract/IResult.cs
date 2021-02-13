using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        bool Success { get; } //sadece okunabilir old. get
        string Message { get; }
    }
}
