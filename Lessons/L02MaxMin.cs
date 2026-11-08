static class L02MaxMin
{
    public static void Run()
    {
        int[] werte = new int[] { 4, 6, 42, 553, 342, 2 };

        int max = werte[0];
        int min = werte[0];

        for (int i = 1; i < werte.Length; i++)
        {
            if (werte[i] > max)
            {
                max = werte[i];
            }

            if (werte[i] < min)
            {
                min = werte[i];
            }
        }

        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
    }
}
