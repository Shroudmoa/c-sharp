// L02 - Maximum und Minimum in einem Array
// Zeigt: Startwert = erstes Element, Schleife ab Index 1, Vergleich mit max/min
// Falle: Bedingung "i > laenge" statt "i < laenge" -> Schleife laeuft nie,
//        das Ergebnis bleibt der Startwert (Semantikfehler, Compiler schweigt)
// Erwartet: Max 553, Min 2

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
