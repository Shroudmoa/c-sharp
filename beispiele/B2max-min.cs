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


