using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[10];
            int stormsIndex = 0;



            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            storms[stormsIndex] = p.CastWindStorm();
            stormsIndex++;

            Mage mag = new Mage("Gul'dan", "Draenor");
            storms[stormsIndex] = mag.CastRainStorm();
            stormsIndex++;

            Archmage arc = new Archmage("Nielas Aran", "Stormwind");
            storms[stormsIndex] = arc.CastWindStorm();
            stormsIndex++;
            storms[stormsIndex] = arc.CastRainStorm();
            stormsIndex++;
            storms[stormsIndex] = arc.CastLightningStorm();
            stormsIndex++;

            for (int i = 0; i < stormsIndex; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }


        }
    }
}