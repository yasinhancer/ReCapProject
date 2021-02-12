using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
    public class ErrorResult : Result
    {
        //burada da boolleri kaldırıp, sondaki base(FALSE) kodu sayesinde false döndürdük ve iki farklı versiyon sayesinde,
        //hem mesajlı hem de mesajsız olarak işlem sonucu verilebilir.
        public ErrorResult(string message) : base(false,message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
