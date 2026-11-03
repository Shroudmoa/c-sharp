Console.WriteLine("mova test --------------------- ");
//IHK be like =>
//- **Syntaxfehler:** Verstoß gegen die Grammatik der Programmiersprache; Compiler meldet Fehler. Beispiel: `int x = "Hallo";` (Typkonflikt) oder fehlendes Semikolon `int x = 5`.
// - **Semantikfehler:** Code ist syntaktisch korrekt, aber die Logik ist falsch; Compiler meldet nichts, Laufzeitverhalten ist falsch. Beispiel: `RAM2[i*2+1] = i;` statt `i+1` – Programm läuft, liefert aber falsche Werte.


int[] Cpuload = new int[] {23, 34, 4, 22, 33, 11};
int summe = 0;
/////////////
for (int i = 0; i < Cpuload.Length; i++)
{

    summe += Cpuload[i];
  //  Console.WriteLine(summe);

  }
////////////////////////////////////////////////////7777
double mit = (double) summe / Cpuload.Length;





Console.WriteLine("Ergebnisse");
Console.WriteLine(summe);
Console.WriteLine(mit);






// Console.WriteLine("test");
//
// Console.WriteLine("t");
// Console.WriteLine("test2");
