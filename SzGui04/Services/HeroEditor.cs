using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzGui04.Models;

namespace SzGui04.Services
{
    public class HeroEditor : IHeroEditor
    {
        public void Edit(Superhero hero)
        {
            new HeroEditorWindow(hero).ShowDialog();
        }
    }
}
