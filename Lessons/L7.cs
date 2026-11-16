static class L7
{
  public static void Run()
  {
    Console.WriteLine("S 2022");
    int[] werte = { 30, 22, 33, 22, 21, 33};
    int temp;
    int len = werte.Length;
    for (int p = 0; p < len - 1; p++) {
      for (int i = 0; i < len - 1 - p; i++) {
        if (werte[i] > werte[i + 1]) {
          temp = werte[i];
          werte[i] = werte[i + 1];
          werte[i + 1] = temp;
        }
      }
    }

    foreach (int w in werte) {
      Console.Write(w + " ");
    }
    Console.WriteLine();

  }

}
