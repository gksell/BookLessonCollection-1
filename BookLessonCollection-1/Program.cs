using System;

namespace BookLessonCollection_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// CreateInstance : Yeni dizi- değişken tipi ve eleman sayısı ile tanımlama

            //Array notArray = Array.CreateInstance(typeof(int), 5); // Tek Boyutlu 3 elemanlı 
            //int[] notArrayList = (int[])notArray; // Object olduğundan dolayı diziye dönüştürüyoruz.
            //notArrayList[0] = 40;
            //notArrayList[1] = 30;
            //notArrayList[2] = 20;
            //notArrayList[3] = 10;
            //notArrayList[4] = 50;
            //Console.WriteLine(notArrayList[1]);

            //// IsArray : Bir Değişkenin Dizi Metodu olup olmadığını anlamak için kullanılan metod

            //string[] isimList = { "Göksel", "Merve", "Deniz" };
            //string ad = "Çiğdem";
            //Type tip; // isimList ve ad tipini öğrenmek için.
            //tip = isimList.GetType();
            //Console.WriteLine(tip.IsArray);
            //tip = ad.GetType();
            //Console.WriteLine(tip.IsArray);

            //// SetValue : Dizi elemanlarına değer atamak için == GetValue : Dizi içi elemana erişmek

            //Array arraySet = Array.CreateInstance(typeof(string), 2);
            //arraySet.SetValue("Merhaba", 0);
            //arraySet.SetValue("Dünya", 1);
            ////arraySet.SetValue("Belirlenen index dışı", 2);
            //Console.WriteLine(arraySet.GetValue(1));

            //// Örnek 1.1 Dizi içindeki tüm elemanları listeleme SetValue-GetValue

            //Array diller = Array.CreateInstance(typeof(string), 3, 3);
            //diller.SetValue("VB.NET", 0, 0);
            //diller.SetValue("C#", 0, 1);
            //diller.SetValue("PHP", 0, 2);
            //diller.SetValue("JS", 1, 0);
            //diller.SetValue("JAVA", 1, 1);
            //diller.SetValue("C", 1, 2);
            //diller.SetValue("C++", 2, 0);
            //diller.SetValue("REACT", 2, 1);
            //diller.SetValue("ANGULAR", 2, 2);

            //for (int i = 0; i < diller.GetLength(0); i++) // Dizinin elemanlarını okumak için
            //{
            //    for (int j = 0; j < diller.GetLength(1); j++) // Dizi boyutu için
            //    {
            //        Console.Write(diller.GetValue(i, j)+" ");
            //        if (j ==diller.GetLength(1)-1)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //// JOIN : Dizi içi değerleri bir ayırıcı kullanarak string değişkene aktarır. 
            //// Dizi elemanlarını string içine alırken kullanıyoruz

            //int[] sayilar = { 0, 1, 2, 3, 4 };
            //string cumle = string.Join("/", sayilar);
            //Console.WriteLine(cumle);

            ////Copy : Diziden diziye kopyalama yapmak için kullanılır

            //int[] number = { 0, 1, 3, 4, 6, 7, 5 };
            //int[] numberCopy = new int[7];
            //Array.Copy(number, numberCopy,6);

            //foreach (int item in numberCopy)
            //{
            //    Console.WriteLine(item);
            //}

            //string aranan;
            //Console.Write("Aranan değeri giriniz: ");
            //aranan = Console.ReadLine();

            //SearchArray.ContainsMethod(aranan);
            //SearchArray.IndexOfMethod(aranan);
            //SearchArray.LastIndexOfMethod(aranan);
            //SearchArray.BinarySearchMethod(aranan);

            //CollectionClass.ArrayListMethod();
            //CollectionClass.HashTableMethod(Convert.ToInt32(aranan));
            //CollectionClass.SortedListMethod(aranan);
            //CollectionClass.GenericListMethod(aranan);
            //CollectionClass.ListPerformans();
            //CollectionClass.StackMethod();
            //CollectionClass.QueueMethod();
            //CollectionClass.LinkedListMethod();
            //CollectionClass.DictionaryMethod();
            //CollectionClass.SortedDictionaryMethod();
            //CollectionClass.SortedSetMethod();
            //CollectionClass.HashSetMethod();

            //int n = 8;
            //int sayac = 0;
            //for (int i = n; i > 0; i /= 2)
            //    sayac++;

            //Console.WriteLine(sayac);

            //int n = 3;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0,5}","*");
            //    }
            //    Console.WriteLine();
            //}
            //int n = 3, sayac = 0;
            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < i; j++)
            //        sayac++;

            //Console.WriteLine(sayac);
            int x = 2;
            int y = ++x * 2;
            Console.WriteLine(y);
            
        }
    }
}
