using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Client
{
    public class ModelClient : INotifyPropertyChanged
    {
        private string word;

        public string Word
        {
            get { return word; }
            set
            {
                word = value;
                OnPropertyChanged("Word");
            }
        }

        public ModelClient(string Text)
        {
            this.Word = Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
