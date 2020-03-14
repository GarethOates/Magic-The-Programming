using System;

namespace MagicTheProgramming.Common
{
    public interface ICreature
    {
        int Counters {get; set;}
        string Name {get;}
        int Power {get;}
        int Toughness {get;}
        void Update();
    }
}
