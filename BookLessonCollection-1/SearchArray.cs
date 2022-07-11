using System;
using System.Collections.Generic;
using System.Text;

namespace BookLessonCollection_1
{
    public static class SearchArray
    {

        private static string[] isimler = { "Göksel", "Aydın", "Ali", "Veli", "Selami","Göksel" };
        /// <summary>
        /// Contains Kullanım Örneği
        /// </summary>
        public static void ContainsMethod(string arananDeger)
        {
            // Contains True - False döner arama yapılan kelime var mı yok mu kontrol
            foreach (var item in isimler)
            {
                if (item.Contains(arananDeger))
                {
                    Console.WriteLine("Aranan Değer var.");
                    break;
                }
            }

        }
        /// <summary>
        /// Index Of : Aranan Değer varsa değerin index nosu yok ise -1 döndürür.
        /// </summary>
        public static void IndexOfMethod(string arananDeger)
        {
            int indexNo;
            indexNo = Array.IndexOf(isimler, arananDeger);
            if (indexNo == -1)
            {
                Console.WriteLine("Aranan değer bulunamadı.");
            }
            else
            {
                Console.WriteLine("Aranan Değer Bulundu. Index No : {0}" , indexNo);
            }
        }
        /// <summary>
        /// Arama yapılan eleman liste içinde birden fazla ise kullanılır.
        /// </summary>
        /// <param name="arananDeger"></param>
        public static void LastIndexOfMethod(string arananDeger)
        {
            int indexNo;
            indexNo = Array.LastIndexOf(isimler, arananDeger);
            if (indexNo == -1)
            {
                Console.WriteLine("Aranan değer bulunamadı.");
            }
            else
            {
                Console.WriteLine("Aranan Değer Bulundu. Index No : {0}", indexNo);
            }
        }
        /// <summary>
        /// Binary Search ile arama yapmak için dizinin sıralı olması gerekir.
        /// </summary>
        public static void BinarySearchMethod(string arananDeger)
        {
            
            int indexNo;
            indexNo = Array.BinarySearch(isimler, arananDeger);
            if (indexNo < 0)
            {
                Console.WriteLine("Aranan değer bulunamadı.");
            }
            else
            {
                Console.WriteLine("Aranan Değer Bulundu. Index No : {0}", indexNo);
            }
        }

    }
}
