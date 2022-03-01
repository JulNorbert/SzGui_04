using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzGui04.Models;

namespace SzGui04.Logic
{
    public class HeroLogic : IHeroLogic
    {
        IList<Superhero> working;
        IList<Superhero> atHome;
        IMessenger messenger;

        public HeroLogic(IMessenger messenger)
        {
            this.messenger = messenger;
        }


        public double AVGPower
        {
            get
            {
                return Math.Round(working.Count == 0 ? 0 : working.Average(x => x.Power), 2);
            }
        }
        public double AVGSpeed
        {

            get
            {
                return Math.Round(working.Count == 0 ? 0 : working.Average(x => x.Speed), 2);
            }
        }

        public void GoToWork(Superhero hero)
        {
            working.Add(hero.GetCopy());
        }

        public void GoHome(Superhero hero)
        {
            working.Remove(hero);
        }

        public void SetupCollections(IList<Superhero> working, IList<Superhero> atHome)
        {
            this.working = working;
            this.atHome = atHome;
        }
    }
}
