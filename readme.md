# C# Lernen

## Struktur

```
Program.cs        Menue - startet die Lektionen (einzige Datei mit Top-Level-Statements)
Lessons/          eine Datei pro Lektion, jeweils static class ... { public static void Run() }
readme.md         Notizen / Theorie
```

Starten: `dotnet run` -> Nummer eingeben.
Pruefen: `dotnet build` -> prueft **alle** Lektionen auf Syntax- und Tippfehler.

## Neue Lektion anlegen

1. `Lessons/L03Thema.cs` erstellen:

   ```csharp
   // L03 - Thema
   // Zeigt: ...
   // Erwartet: ...

   static class L03Thema
   {
       public static void Run()
       {
           // Code
       }
   }
   ```

2. In `Program.cs` eine Zeile im Menue und einen `case` ergaenzen.
3. `dotnet build`, `dotnet run`, Ergebnis mit "Erwartet" vergleichen.
4. Commit: `L03: Thema`.

Wichtig: In Lektionsdateien **keine** Top-Level-Statements (also kein Code
ausserhalb der Klasse) - sonst Compilerfehler CS8802.

## IHK

- **Syntaxfehler:** Verstoß gegen die Grammatik der Programmiersprache; Compiler meldet Fehler. Beispiel: `int x = "Hallo";` (Typkonflikt) oder fehlendes Semikolon `int x = 5`.
- **Semantikfehler:** Code ist syntaktisch korrekt, aber die Logik ist falsch; Compiler meldet nichts, Laufzeitverhalten ist falsch. Beispiel: `RAM2[i*2+1] = i;` statt `i+1` – Programm läuft, liefert aber falsche Werte.

## Gemerkte Fehler

| Fehler | Ursache | Loesung |
|---|---|---|
| `CS0103` Name existiert nicht | Variable nie deklariert oder Tippfehler (`wetre` statt `werte`) | deklarieren / Schreibweise pruefen |
| `CS8802` nur eine Datei mit Top-Level-Statements | zweite Datei mit Code ausserhalb einer Klasse | Code in `static class` + `Run()` |
| `CS0149` / `CS1586` Array | `new int[4] (…)` statt `new int[] { … }` | geschweifte Klammern benutzen |
| `CS0019` Operator `-=` | `int` minus `int[]` | `arr[i]` statt `arr` |
| Semantik: Schleife laeuft nie | `i > arr.Length` statt `i < arr.Length` | Vergleichsrichtung pruefen |
