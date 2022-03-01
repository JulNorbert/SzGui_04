using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzGui04.Models
{
    public enum Alignment { good,bad,neutral}
    public class Superhero: ObservableObject
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { SetProperty(ref speed, value); }
        }
        private int power;
        public int Power
        {
            get { return power; }
            set { SetProperty(ref power, value); }
        }
        private int name;
        public int Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        private Alignment alignment;
        public Alignment Alignment
        {
            get { return alignment; }
            set { SetProperty(ref alignment, value); }
        }
    }
}