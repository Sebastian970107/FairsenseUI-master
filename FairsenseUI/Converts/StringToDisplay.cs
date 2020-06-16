using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FairsenseUI.Converts
{
    public class StringToDisplay: INotifyPropertyChanged
    {
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                if (text != value)
                {
                    text = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Text"));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
