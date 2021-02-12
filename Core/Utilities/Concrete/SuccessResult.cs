using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
    public class SuccessResult : Result
    {
        //burada direkt successresult adında oluşturduğumuz için, bool'leri kaldırdık. base'e true dönmesi için de base ekledik
        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}
