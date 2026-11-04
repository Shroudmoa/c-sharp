// L01 - Mittelwert eines Arrays
// Zeigt: Array aufbauen, mit for-Schleife durchlaufen, Summe bilden,
//        Division mit (double)-Cast (sonst ganzzahlige Division!)
// Erwartet: Summe 127, Mittelwert 21,1666...

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

        // Cast VOR der Division, sonst rechnet C# ganzzahlig (127 / 6 = 21)
        double mittelwert = (double)summe / cpuload.Length;

        Console.WriteLine("Summe:      " + summe);
        Console.WriteLine("Mittelwert: " + mittelwert);
    }
}
