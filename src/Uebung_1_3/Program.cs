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
        int note;
        note = new  note[namen.length];
        int[] punkte = { 21, 18, 15 };
        for(int i = 1; i < namen.length; i++ )
        {
            note[i-1] = getNote(punkte[i-1]);
        }
    }
    public static int getNote(int punkteAnzahl)
    {
        int note = 1;
        if(punkteAnzahl >= 21)
        {
            return note;
        }
        else if(punkteAnzahl >= 18  && punkteAnzahl < 21)
        {
            return note + 1;
        }
        else if(punkteAnzahl >= 15  && punkteAnzahl < 18)
        {
            return note + 2;
        }
        else if(punkteAnzahl >= 12  && punkteAnzahl < 15)
        {
            return note + 3;
        }
        else
        {
            return note + 4;
        }
    }
    public static int getNoteText(int note)
    {
        if(note == 1)
        {
            
        }
    }
}