using System;

namespace MagicTheProgramming.Common
{
    public interface ICreature
    {
        string Name {get;}
        int Power {get;}
        int Toughness {get;}
        void Update(IPlayer player);
    }
}
