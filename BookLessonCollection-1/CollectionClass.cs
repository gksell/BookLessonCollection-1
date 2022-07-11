using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace BookLessonCollection_1
{
    public class Compare : IComparer
    {
        /// <summary>
        /// Tersten sıralama için Interfaceden türettiğimiz classımız.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int IComparer.Compare(object x, object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }
    /// <summary>
    /// Farklı türden verilerin bir arada saklanabildiği yapılardır.
    /// Bellekteki alanı eklenen eleman sayısına göre otomatik belirlenir.
    /// boxing / unboxing dönüşümleri yapılabilir.
    /// Generic-Non-Generic-Specialized
    /// </summary>
    public static class CollectionClass
    {
        //Non-Generic Kolleksiyonlar - Farklı türlerdeki verilerin bir arada saklanabildiği,
        //boxing ile obje türüne dönüştürülür.
        //ArrayList - HashTable - SortedList

        public static void ArrayListMethod()
        {
            
            Compare CompareOptions = new Compare();
            ArrayList isimler = new ArrayList();
            ArrayList sayilar = new ArrayList();
            sayilar.Add("Merhabalar...");
            sayilar.Add("Merhabalar2");
            sayilar.Add("Merhabalar2");
            sayilar.Add("Merhabalar4");

            isimler.Add("Göksel");
            isimler.Add("Veli");
            isimler.Add("Selami");
            isimler.Add("Ali");
            /*isimler.Add(false);*/ // farklı tür değerleri aynı liste içinde tanımlıyoruz.
            //isimler.Add(123);
            //Console.WriteLine(isimler[0]);

            // İstenen yere eleman eklemek için Insert kullanılır.

            //isimler.Insert(0, "zzz");
            //Console.WriteLine(isimler[0]);
            //isimler.Sort(); // ArrayList sıralama için 
            //Console.WriteLine(isimler[0]);
            //isimler.Sort(CompareOptions);
            //Console.WriteLine(isimler[0]);

            //Console.WriteLine("-----------");

            //for (int i = 0; i < isimler.Count; i++) 
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            //isimler.Remove("Göksel"); Sadece göksel olan değeri siler.
            //isimler.Clear(); Toplu Temizlik
            //isimler.RemoveAt(3); Belirtilen indis değerini siler.
            //isimler.Reverse(); Diziyi tersine çevirir
            //var arrayCapacity = isimler.Capacity; // Dizi kapasitesi 4 katı şeklinde görüntülenir.
            //isimler.GetRange(0, 2); // 0.indisten itibaren 2 eleman al 
            //isimler.AddRange(sayilar); Dizi içine başka bir dizi ekliyoruz. Addden farkı range ile ekleme yapması olacak
            //isimler.InsertRange(1, sayilar); //1. indisten itibaren sayiları range ekle .
            //isimler.RemoveRange(0, 2); 0.indisten itibaren 2 indis sil
            //isimler.CopyTo(sayilar.ToArray()); // sayilar dizisinden isimler dizisine kopyalama işlemi yapılır.
            // index numarasından itibaren de kopyalama yapılabilir.
            //sayilar.CopyTo(isimler, 0);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            // ToArray ?

            //string[] yeniDizi = (string[])isimler.ToArray(typeof(string)); // ArrayList içindeki elemanları yeni dizi oluşturup o diziye ekleme type ile beraber
            //foreach (var item in yeniDizi)
            //{
            //    Console.WriteLine(item);
            //}
        }
        /// <summary>
        /// HashTable sınıfında index numarası ile değil key value ile giriş çıkış yapılır. 
        /// </summary>
        public static void HashTableMethod(int arananDeger)
        {
            Hashtable isimler = new Hashtable();
            isimler.Add(1, "Merhaba");
            isimler.Add(2, "Merhabalar");
            isimler.Add(3, "Merhaba dünya");

            //ICollection degerler = isimler.Values; // değerler value dan alındı.
            //foreach (var item in degerler)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (DictionaryEntry item in isimler) // Hem key hem value erişimi için DictionaryEntry
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //if (isimler.ContainsKey(arananDeger) == true)
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Değil");
            //}



        }
        /// <summary>
        /// Elemanlara erişim hem index hem key aracılığı ile yapılır.
        /// İçerisindeki değerler sıralı bir şekilde saklanır.
        /// </summary>
        public static void SortedListMethod(string arananDeger)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(5, "z");
            sortedList.Add(2, "b");
            sortedList.Add(3, "i");
            sortedList.Add(4, "d");
            //Console.WriteLine(sortedList.IndexOfKey(1)); // Aranan değerin index numarasını key ile arama
            //Console.WriteLine(sortedList.GetKey(3)); // 3.indexin anahtarı
            //Console.WriteLine(sortedList.GetByIndex(3));  // 3. indisin valuesi 
            //foreach (DictionaryEntry item in sortedList) // Key value almak için
            //{
            //    Console.WriteLine(item.Key + " " + item.Value); 
            //}

            //IDictionaryEnumerator eleman = sortedList.GetEnumerator;
        }
        /// <summary>
        /// saklanacak veri türünün seçildiği metodlardır.boxing- unboxing yoktur.
        /// Daha Performanslıdır.
        /// ArrayList benzeri yapılardır.
        /// </summary>
        public static void GenericListMethod(string arananDeger)
        {
            List<string> liste = new List<string>();
            liste.Add("Merhaba 1");
            liste.Add("Merhaba 2");
            liste.Add("Merhaba 3");
            ArrayList arrayList = new ArrayList(liste);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// List nesne performansı-- 100.000 rastgele sayıyı ekleme
        /// </summary>
        public static void ListPerformans()
        {
            DateTime baslangiczamani;
            DateTime bitiszamani;
            TimeSpan fark;

            List<int> rastgeleList = new List<int>();
            Random rastgele = new Random();
            int sayi;

            for (int i = 0; i < 100000; i++)
            {
                sayi = rastgele.Next(1, 100);
                rastgeleList.Add(sayi);
            }

            baslangiczamani = DateTime.Now;
            //for (int i = 0; i < rastgeleList.Count-1; i++)
            //{
            //    for (int j = rastgeleList.Count-1; j>= i+1; j+=-1)
            //    {
            //        if (rastgeleList[i]==rastgeleList[j])
            //        {
            //            rastgeleList.RemoveAt(j);
            //        }
            //    }
            //}
            //bitiszamani = DateTime.Now;
            //fark = bitiszamani.Subtract(baslangiczamani);
            //Console.WriteLine(fark.TotalSeconds.ToString());

            List<int> rasgeleListTekrarsiz = new List<int>();

            rasgeleListTekrarsiz.AddRange(rastgeleList.Distinct().ToArray());
            bitiszamani = DateTime.Now;
            fark = bitiszamani.Subtract(baslangiczamani);
            Console.WriteLine(fark);



        }
        /// <summary>
        /// LAST IN FİRST OUT
        /// Eklenen son elemana ilk olarak erişilebilir.
        ///Push ekleme
        /// </summary>
        public static void StackMethod()
        {
            Stack<string> isimler = new Stack<string>();
            isimler.Push("Göksel");
            isimler.Push("Merve");
            isimler.Push("Çiğdem");
            isimler.Push("Ali");
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(isimler.Peek()); // En üst sırada bulunan eleman
            isimler.Pop(); // Son eklenen elemanı siler
            Console.WriteLine(isimler.Peek());
            
        }
        /// <summary>
        /// İLK GİREN İLK ÇIKAR MANTIĞI İLE ÇALIŞIR.
        /// </summary>
        public static void QueueMethod()
        {
            Queue<int> kuyruk = new Queue<int>();
            kuyruk.Enqueue(1);
            kuyruk.Enqueue(2);
            kuyruk.Enqueue(3);
            Console.WriteLine(kuyruk.Peek());
            kuyruk.Dequeue();
            Console.WriteLine(kuyruk.Peek());
        }
        /// <summary>
        /// Elemanların birbirine link şeklinde bağlı olduğu method.
        /// AddFirst : Baştan ekleme
        /// AddLast : Sondan ekleme
        /// </summary>
        public static void LinkedListMethod()
        {
            LinkedList<int> liste = new LinkedList<int>();
            liste.AddFirst(1);
            liste.AddLast(3);
            liste.AddLast(1);
            //Console.WriteLine(liste.First.Value + " " + liste.Last.Value); // İlk ve Son değeri görüntüleme 
            liste.AddLast(43);
            liste.AddLast(99);

            // Remove - Değeri verilen elemanı silmek için
            // RemoveFirst - İlk elemanı silmek için 
            // RemoveLast - Son elemanı silmek için
            LinkedListNode<int> bulunan = liste.Find(43);
            liste.AddBefore(bulunan, 78);
            liste.AddAfter(bulunan, 49);
            Console.WriteLine(bulunan.Value + " " + bulunan.Next.Value + " " +bulunan.Previous.Value); 
            // Find ile istenen değer - next ile istenen değer sonrası - previous ile istenen değerin öncesi
            
        }
        /// <summary>
        /// anahtar tekil - value çoğul olabilir. key türü belirtilmeli.
        /// </summary>
        public static void DictionaryMethod()
        {
            Dictionary<string, int> sınıflar = new Dictionary<string, int>();
            sınıflar.Add("a", 5);
            sınıflar.Add("b", 7);
            sınıflar.Add("c", 40);
            sınıflar.Add("d", 20);
            //foreach (var item in sınıflar)
            //{
            //    Console.WriteLine(item); // [key,value] listeleme yapılır.
            //}
            //sınıflar.Remove(40); // key ile silme
            sınıflar["a"] = 48;

            //foreach (KeyValuePair<int,int> item in sınıflar)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value); // key - value listeleme yaptık.
            //}
            //foreach (var item in sınıflar.Keys.ToList()) // Key leri listeleme yaptık .
            //{
            //    Console.WriteLine(item);
            //}
            // Sıralama için önce listeye dönüştürüp sonra sort kullanabiliriz.
            //List<int> sıralamaListesi = new List<int>(sınıflar.Keys);
            //sıralamaListesi.Sort();
            //foreach (var item in sıralamaListesi)
            //{
            //    Console.WriteLine(item);
            //}
            //var sırala = from eleman in sınıflar
            //             orderby eleman.Key descending
            //             select eleman.Value; // Link ile keylere göre sıralayıp valueları aldık.
            //foreach (var item in sırala)
            //{
            //    Console.WriteLine(item);
            //}
            //var mgecenler = sınıflar.Where(x => x.Key.StartsWith("a")).Select(x=>x.Key).ToList(); // keyi a ile başlayanları listele.
            //foreach (var item in mgecenler)
            //{
            //    Console.WriteLine(item);
            //}

            ////DictionaryInıtıalizer...
            //Dictionary<string, string> stringDictionary = new Dictionary<string, string>()
            //{
            //    ["1"] = "Merhaba",
            //    ["2"] = "Merhaba 2"
            //};
            //foreach (var item in stringDictionary)
            //{
            //    Console.WriteLine(item);
            //}


        }
        /// <summary>
        /// Dictionaryden farklı olarak Sıralama işlemi yapar keye göre. 
        /// Daha az performanslıdır.
        /// </summary>
        public static void SortedDictionaryMethod()
        {
            SortedDictionary<int, int> keyValuePairs = new SortedDictionary<int, int>()
            {
                [17] = 1,
                [2] = 3,
                [13] = 4
            };
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Elemanları sıralı yazan generic liste.
        /// Aynı eleman iki kere eklenemez.
        /// </summary>
        public static void SortedSetMethod()
        {
            SortedSet<string> liste = new SortedSet<string>()
            {
                "Merhaba",
                "Adana",
                "Göksel",
                "Merve",
                "BBBB",
                "Merve"
            };
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //liste.RemoveWhere(x => x.Contains("Merhaba")); // Koşullu silme 
            //var a = liste.Where(x => x != "Merhaba").ToList();
        }
        /// <summary>
        /// Daha önceden eklenen bir değeri eklemez. 
        /// Değer ekleme ve arama işlemleri çok daha hızlıdır. Hash koleksiyon özelliği
        /// Key value yoktur. Generic türdür.
        /// </summary>
        public static void HashSetMethod()
        {
            HashSet<int> liste = new HashSet<int>();
            Random random = new Random();
            int sayi;
            List<int> liste2 = new List<int>();
            liste2.Add(1);
            liste2.Add(5);
            liste2.Add(5005);
            
            for (int i = 0; i < 1000; i++)
            {
                sayi = random.Next(1, 100);
                liste.Add(sayi);
                //liste2.Add(sayi);
            }
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("Sayi {0}",liste.Count);
            Console.WriteLine("Sayi {0}", liste2.Count);
            if (liste.SetEquals(liste2)) // Karşılaştırma yapılırken tekrar eden değer göz ardı ediliyor.
            {
                Console.WriteLine("Eşittir.");
            }
            else
            {
                Console.WriteLine("Değildir.");
            }
             liste.IntersectWith(liste2);
            Console.WriteLine(liste.Count);
        }
    }
}
