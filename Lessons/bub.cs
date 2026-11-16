using System;

static class bub
{
    public static void Run()
    {
        // 1. Das Array initialisieren
        int[] werte = { 30, 24, 12, 50, 11, 49, 11 };
        int temp;
        int len = werte.Length; // Datentyp 'int' hinzugefügt (fehlte im Bild)

        Console.WriteLine("Start-Array: " + string.Join(", ", werte));
        Console.WriteLine("--------------------------------------------------");

        // Äußere Schleife: Bestimmt die Anzahl der Durchläufe
        for (int p = 0; p <= len - 2; p++)
        {
            Console.WriteLine($"\n---> Äußerer Durchlauf p = {p}");
            bool getauscht = false; // Um zu sehen, ob in diesem Durchlauf was passiert ist

            // Innere Schleife: Vergleicht die Elemente
            for (int i = 0; i <= len - 2 - p; i++)
            {
                // Wenn das linke Element größer ist als das rechte -> Tauschen
                if (werte[i] > werte[i + 1])
                {
                    Console.WriteLine($"     Tausche {werte[i]} (Index {i}) mit {werte[i + 1]} (Index {i + 1})");
                    
                    // Der Tausch (mit temp)
                    temp = werte[i + 1];
                    werte[i + 1] = werte[i];
                    werte[i] = temp;

                    getauscht = true;
                    
                    // Aktuellen Zustand ausgeben
                    Console.WriteLine("     Aktuell: [" + string.Join(", ", werte) + "]");
                }
            }

            // Wenn in einem kompletten Durchlauf nichts getauscht wurde, ist das Array fertig sortiert
            if (!getauscht)
            {
                Console.WriteLine("     Keine Tauschaktion in diesem Durchlauf. Array ist fertig sortiert!");
                break; 
            }
        }

        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("End-Array:   " + string.Join(", ", werte));
    }
}
