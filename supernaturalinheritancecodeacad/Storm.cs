using System;

namespace MagicalInheritance
{
    class Storm : Spell
    {
        public Storm(string essence, bool isStrong, string caster)
        {
            Caster = caster;
            IsStrong = isStrong;
            Essence = essence;
        }

        public override string Announce()
        {
            if (IsStrong == true)
            { return $"{Caster} cast a strong {Essence} storm!"; }
            else
            { return $"{Caster} cast a weak {Essence} storm!"; }
        }

    }
}