using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PharmacyApp.ViewModels
{
    public class DetailPageViewModel 
    {
       

        private readonly ICommand _menuCommand;

        public DetailPageViewModel()
        { 
            _menuCommand = new Command(MenuCommandExecute);
        }

        

        public ICommand MenuCommand
        {
            get
            {
                return _menuCommand;
            }
        }

        private void MenuCommandExecute(object args)
        {
            MessagingCenter.Send<DetailPageViewModel>(this, "Pop");
        }
        
        
    }
}
