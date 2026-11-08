static class L01Mittelwert
{
    public static void Run()
    {
        int[] cpuload = new int[] { 23, 34, 4, 22, 33, 11 };

        int summe = 0;

        for (int i = 0; i < cpuload.Length; i++)
        {
            summe += cpuload[i];
        }

        double mittelwert = (double)summe / cpuload.Length;

        Console.WriteLine("Summe:      " + summe);
        Console.WriteLine("Mittelwert: " + mittelwert);
    }
}
