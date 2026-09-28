// ------------------------------
// Uebung_1_3
// ------------------------------

using System.Reflection.Metadata.Ecma335;

namespace Uebung_1_3;

class Program
{
    static void Main(string[] args)
    {

        string[] namen = { "Mayer", "Huber", "Gruber" };
        int[] note;
        note = new int[namen.Length];
        int[] punkte = { 21, 18, 15 };
        for (int i = 0; i < namen.Length; i++)
        {
            note[i] = getNote(punkte[i]);
            getNoteText(note[i], namen[i]);
        }
    }
    public static int getNote(int punkteAnzahl)
    {
        int notee = 1;
        if (punkteAnzahl >= 21)
        {
            return notee;
        }
        else if (punkteAnzahl >= 18 && punkteAnzahl < 21)
        {
            return notee + 1;
        }
        else if (punkteAnzahl >= 15 && punkteAnzahl < 18)
        {
            return notee + 2;
        }
        else if (punkteAnzahl >= 12 && punkteAnzahl < 15)
        {
            return notee + 3;
        }
        else
        {
            return notee + 4;
        }
    }
    public static void getNoteText(int note, string name)
    {
        if (note == 1)
        {
            Console.WriteLine($"{name}-{note}(sehr gut)");
        }
        else if (note == 2)
        {
            Console.WriteLine($"{name}-{note}(gut)");
        }
        else if (note == 3)
        {
            Console.WriteLine($"{name}-{note}(befriedigend))");
        }
        else if (note == 4)
        {
            Console.WriteLine($"{name}-{note}(genügend)");
        }
        else
        {
            Console.WriteLine($"{name}-{note}(nicht genügend)");
        }
    }
}