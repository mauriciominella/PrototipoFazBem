using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using System.Runtime.CompilerServices;

namespace FazBem.ViewModels
{
    public abstract class ViewModelBase: ViewModel
    {
        protected readonly Services.INavigationService _navigationService;
        protected readonly Services.IMessageService _messageService;

        public ViewModelBase()
        {
            this._navigationService = DependencyService.Get<Services.INavigationService>();
            this._messageService = DependencyService.Get<Services.IMessageService>();
        }
			
        protected void Notify([CallerMemberName] string propertyName = "")
        {
			NotifyPropertyChanged (propertyName);
        }
    }
}
