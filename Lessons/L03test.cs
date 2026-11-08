static class L03test
{
    public static void Run()
    {
        Console.WriteLine("give me a numl");

        string input = Console.ReadLine();
        int x;
        if(!int.TryParse(input, out x)) {
          Console.WriteLine("bru");
          return;
        }

        if (x > 50) {
          Console.WriteLine("so x is bigger then the 50");
        } else if (x == 50) {
          Console.WriteLine("x is = 50 i repeat x is 50");
        } else {
          Console.WriteLine("x is not bigger than 50");
        }

        Console.WriteLine("here is the x:" +  + x );

    }
}
