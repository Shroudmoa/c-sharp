// Menue: startet die einzelnen Lektionen aus dem Ordner Lessons/
// Jede Lektion ist eine static class mit einer public static void Run().

while (true)
{
    // Console.WriteLine("\nava 0.1.0");
    // string [] menu = {"1) mittwert","2", "3", "0"};
    //
    // foreach (var item in menu){
    //     Console.WriteLine(item);
    // }
    Console.WriteLine(@"
        ava 0.0.1
1) mittwert
2) idk 
3) 50 ?
0) sandbox
        ");
    Console.Write("Auswahl (Enter = Ende): ");


//////////////////////////////////////////
    string? eingabe = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(eingabe))
    {
        break;
    }

var menu = new Dictionary<string, Action>
{
  {"1", L01Mittelwert.Run },
  { "2", L02MaxMin.Run },
  { "0", L00Sandbox.Run },
  { "3", L03test.Run }
};
if (menu.TryGetValue(eingabe, out var action))
{
    Console.Clear();
    action(); // Führt die Methode aus
}
else
{
    Console.WriteLine("Unbekannte Auswahl: " + eingabe);
}
}
////////////////////////////////
//     switch (eingabe)
//     {
//         case "3":
//             L03test.Run();
//             break;
//         case "1":
//             L01Mittelwert.Run();
//             break;
//         case "2":
//             L02MaxMin.Run();
//             break;
//         case "0":
//             L00Sandbox.Run();
//             break;
//         default:
//             Console.WriteLine("Unbekannte Auswahl: " + eingabe);
//             break;
//     }
// }
//
Console.WriteLine("goooooddddddbyyyyy");
