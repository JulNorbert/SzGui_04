using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using SzGui04.Logic;
using SzGui04.Models;
namespace SzGui04.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        IHeroLogic logic;
        public ObservableCollection<Superhero> Left { get; set; }
        public ObservableCollection<Superhero> Right { get; set; }

        private Superhero selectedFromLeft;

        public Superhero SelectedFromLeft
        {
            get { return selectedFromLeft; }
            set
            {
                SetProperty(ref selectedFromLeft, value);
                (AddToRightCommand as RelayCommand).NotifyCanExecuteChanged();
                (EditHeroCommand as RelayCommand).NotifyCanExecuteChanged();
            }
        }
        public ICommand AddToLeftCommand { get; set; }
        public ICommand EditHeroCommand { get; set; }
        public ICommand AddToRightCommand { get; set; }
        public static bool IsInDesignMode { get {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }  }
        public MainWindowViewModel():this(IsInDesignMode ? null : Ioc.Default.GetService<IHeroLogic>()) { }

        public MainWindowViewModel(IHeroLogic logic)
        {
            this.logic = logic;
            logic.SetupCollections(Right, Left);
        }
    }
}