internal class Program
{
    private static void Main(string[] args)
    {
        ////int deger = 0;
        //for (int i = 100; i > 0; i--)
        //{
        //    Console.WriteLine(i);
        //};


        List<User> users = new List<User>
        {
            new User
            {
                Age = 30,
                Name = "Emre"
            },
            new User
            {
                Age = 25,
                Name     = "Halil"
            }

        };
        //int[] nums = { 1, 2, 3, 4, 5 };

        for (int i = 0; i <users.Count; i++)
        {            
            int age = users[i].Age;
            var firstAge = users[0].Age;

            Console.WriteLine(firstAge);
            Console.WriteLine(age);
        }

        foreach (var user in users)
        {
            int age = user.Age;          
            Console.WriteLine(age);
        };

        int x = 0;
        //while (x<100)
        //{
        //    x++;
        //    Console.WriteLine($"Küçük-{x}");
        //};
        //x = 0;
        //var c = 0;
        //do
        //{
        //    c = nums[x] * nums.Last();
        //    Console.WriteLine(c);
        //    x++;
        //} while (c <= 20);


        Console.SetCursorPosition(0,100);

        //  |----------------|
        //  |                |
        //  |                |
        //  |----------------|
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Beep(100,3000);
        

        //do
        //{

        //} while (false);

        Console.WriteLine("Hello, World!");
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}