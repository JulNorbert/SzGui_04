using System.Collections.Generic;
using SzGui04.Models;

namespace SzGui04.Logic
{
    public interface IHeroLogic
    {
        double AVGPower { get; }
        double AVGSpeed { get; }

        void GoHome(Superhero hero);
        void GoToWork(Superhero hero);
        void SetupCollections(IList<Superhero> working, IList<Superhero> atHome);
    }
}