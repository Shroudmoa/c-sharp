// Menue: startet die einzelnen Lektionen aus dem Ordner Lessons/
// Jede Lektion ist eine static class mit einer public static void Run().

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1) Mittelwert berechnen");
    Console.WriteLine("2) Max und Min im Array");
    Console.WriteLine("0) Sandbox");
    Console.Write("Auswahl (Enter = Ende): ");

    string? eingabe = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(eingabe))
    {
        break;
    }

    switch (eingabe)
    {
        case "1":
            L01Mittelwert.Run();
            break;
        case "2":
            L02MaxMin.Run();
            break;
        case "0":
            L00Sandbox.Run();
            break;
        default:
            Console.WriteLine("Unbekannte Auswahl: " + eingabe);
            break;
    }
}

Console.WriteLine("Ende.");
