using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzGui04.Logic;
using SzGui04.Models;

namespace SzGui04.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        IHeroLogic logic;
        ObservableCollection<Superhero> working;
        ObservableCollection<Superhero> atHome;

        private Superhero selectedFromAtHome;

        public Superhero SelectedFromAtHome
        {
            get { return selectedFromAtHome; }
            set {
                SetProperty(ref selectedFromAtHome, value);
                    selectedFromAtHome = value;}
        }

        private Superhero selectedFromWorking;

        public Superhero SelectedFromWorking
        {
            get { return selectedFromWorking; }
            set { selectedFromWorking = value; }
        }


        public MainWindowViewModel(IHeroLogic logic)
        {
            this.logic = logic;

            logic.SetupCollections(working, atHome);
        }
    }
}
