using System;

namespace MagicTheProgramming.Common
{
    public interface IPlayer
    {
        string Name {get; set;}
        int LifeTotal {get; set;}

        void Attach(ICreature creature);
        void Detach(ICreature creature);
    }
}
