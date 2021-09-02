using Client.Model;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class ViewModelClient
    {
        private ObservableCollection<ModelClient> Forbidden_words;

        public ViewModelClient()
        {
            Forbidden_words = new ObservableCollection<ModelClient>();
        }

        public ICommand Add
        {
            get 
            {
                return new RelayCommand(()=>Add_word());
            }
        }

        //public ICommand Delete
        //{
        //    //get
        //    //{
        //    //    return new RelayCommand(() =>);
        //    //}
        //}

        //public ICommand Update
        //{
        //    //get
        //    //{
        //    //    return new RelayCommand(() =>);
        //    //}
        //}

       
        public void Add_word()
        {

        }

        public void Delete_word(string id)
        {
            
        }

        public void Update_word(string id)
        {
            
        }


    }
}
