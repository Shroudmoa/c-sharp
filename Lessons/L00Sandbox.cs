static class L00Sandbox
{
    public static void Run()
    {
        Console.WriteLine("Sandbox - anakin hates u");
        int[] arr = new int[] {33, 44, 22, 23};
        int max44 = arr[0];
        int max233= arr[3];
        int summe = 0; 
        for (int i = 0; i < arr.Length; i++) summe += arr[i];
        double mw = summe / arr.Length;

        Console.WriteLine(mw);
        Console.WriteLine(@"


            ");

        int[] arr2 = new int[] {55, 55, 55, 55, 55, 30, 2, 3, 1, 10, 1000};
        int max2 = 0;
        int max = arr2[0]; 
        for (int x = 0; x < arr2.Length; x++) {
          if (arr2[x] > max) {
            max2 = max; 
            max = arr2[x];

          } else if (arr2[x] > max2 && arr2[x] != max) {
            max2 = arr2[x];
          }
        }
        Console.WriteLine("max 2 is  " + max2 + "   max 1 is " + max);


        
    }
}
