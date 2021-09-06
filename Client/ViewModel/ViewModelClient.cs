using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Windows.Input;

namespace Client
{
    public class ViewModelClient : INotifyPropertyChanged
    {
        private NetworkClient network = new NetworkClient();
        private ModelClient selectedblacklistitem;
        private string addblacklistitem;

        public ObservableCollection<ModelClient> Blacklist { get; set; }

        public ModelClient SelectedBlacklistItem
        {
            get { return selectedblacklistitem; }
            set
            {
                selectedblacklistitem = value;
                OnPropertyChanged("SelectedBlacklistItem");
            }
        }

        public string AddBlacklistItem
        {
            get { return addblacklistitem; }
            set
            {
                addblacklistitem = value;
                OnPropertyChanged("AddBlacklistItem");
            }
        }

        public ViewModelClient()
        {
            Blacklist = new ObservableCollection<ModelClient>();
            Get_blacklist_words();
        }

        public ICommand Add
        {
            get 
            {
                return new RelayCommand(()=>Add_word(AddBlacklistItem));
            }
        }

        public ICommand Delete
        {
            get
            {
                return new RelayCommand(()=>Delete_word(SelectedBlacklistItem));
            }
        }

        public void Add_word(string text)
        {
            if (!String.IsNullOrWhiteSpace(text))
                network.Connect().Add(text);
            this.AddBlacklistItem = string.Empty;
            Get_blacklist_words();
        }

        public void Delete_word(ModelClient id)
        {
            network.Connect().Remove(id.Word);
            Get_blacklist_words();
        }

        public void Get_blacklist_words()
        {
            Blacklist.Clear();
            List<string> items = JsonConvert.DeserializeObject<List<string>>(network.Connect().GetBlackList());
            items.ForEach(x => this.Blacklist.Add(new ModelClient(x)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
