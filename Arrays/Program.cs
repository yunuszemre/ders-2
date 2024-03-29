internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayilar = { 1, 2, 3};
        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }

        sayilar[0] = 6;

        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }
        //Dizi metotları
        Console.WriteLine("Hello, World!");
    }
}