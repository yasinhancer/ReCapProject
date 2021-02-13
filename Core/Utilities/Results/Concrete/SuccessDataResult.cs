namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //burada birden fazla farklı kullanım senaryosu olması adına, 4 tane farklı metot yazdım.
        //birincisinde data,mesaj istedim ve bunu base sınıfa gönderdim, işlem sonucu da classdan dolayı true.
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default,true, message)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
