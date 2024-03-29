internal class Program
{
    private static void Main(string[] args)
    {
        //Değişken tanımlama
        //değişkenin türü -- değişken ismi -- = değişken değeri;
        int sayi = 1;
        //primitive type
        /*
         * integer
         * bool
         * long
         * ulong
         * uint
         * temelde sayısal ifadeye dayanan değişken türleri
         * oluşturuldukları anda değerleri atanmalı
         * -----------------------------------------------------------
         * Ram'in STACK kısmında tutulurlar 
         * 
         * 
         */

        /*Dizi-Liste-Array
         * Aynı türde birden çok veriyi bir arada tutan değişkenler
         * [] => c# ta dizi tanımlama sembolü
         * int[] sayilar = {1,2,3};
         * sayilar[2];
         * dizilerde indexler 0 dan başlar 
         *Diziler oluşturuldukları eleman sayısından fazla eleman barındıramazlar, uzunlukları sabittir
         */
        // Dİzi methotları
        int[] sayilar = [1, 2, 3];
        int[] sayilar2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] sayilar3 = new int[10];

        sayilar3 = sayilar2;


        Console.WriteLine(sayilar.Length);

        Console.WriteLine(sayilar2[9].ToString());
        var c = sayilar2.Clone();
        var dist = sayilar2.Distinct();
        bool isContainsFive = sayilar2.Contains(5);
        bool isContains = sayilar2.Contains(11);
        sayilar3.ElementAt(9);
        var g = sayilar2[3];

        //List
        /*
         * Dizilerin gelişmiş verisyonu
         * 
         */
        List<int> numbers = new List<int>();
        numbers.Add(1);


        bool isUse = false;

        Console.WriteLine(isUse);
        Number sayi2 = new Number();

        Console.WriteLine(sayi);
        //complex type

        Console.WriteLine(sayi2.Value);

        //Console.WriteLine(sayi);//1

        Hesapla(sayi2);//

        Console.WriteLine(sayi2.Value);//1 -- 3
    }
    static void Hesapla(Number sayi)
    {
        sayi.Value = sayi.Value * 3;
    }
    public class Number
    {
        public int Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}