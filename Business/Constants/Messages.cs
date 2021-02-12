using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static : newlemeden, kendi inheriti ile kullanabilmek için (sabit old. newlemeye gerek yok)
    {
        public static string Added = " sisteme eklendi.";
        public static string Deleted = " sistemden silindi.";
        public static string Updated = " sistemde güncellendi.";
        public static string SameEntry = " zaten sistemde mevcut!";
        public static string InvalidData = " sistemde zaten yok!";
        public static string InvalidEntry = "GEÇERSİZ GİRİŞ!";
    }
}
