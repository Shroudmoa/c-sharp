static class L6
{
  public static void Run()
    {
      int[] random = new int[] {23, 33, 44, 55};
      byte anzahl = 4;
      for (int i = 0; i < anzahl; i++) {
        if ((random[i] > 2 ) && (random[i] < 4)) {
          Console.WriteLine("sup");
        } 
      }
    }
}
