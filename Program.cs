Console.WriteLine("mova test ---------------------");









































/////////////
int[] werte = new int[] { 4, 6, 42, 553, 342, 2 };

int max = werte[0];

for (int i = 1; i < werte.Length; i++) {
  if (werte[i] > max) {
    max = werte[i];
  }
}


int[] array2 = new int[] {22, 33, 44, 55, 55};
int min = array2[0];

for (int i = 1; i > array2.Length; i++) {

  if (array2[i] < min) {
    min = array2[i];
  }
}

Console.WriteLine("ur min is" +  min);


/////////////////














////////////////////////777L
///
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

///////////////////////////////


















