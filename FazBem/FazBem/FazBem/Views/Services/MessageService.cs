using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.Views.Services
{
    public class MessageService : ViewModels.Services.IMessageService
    {
        #region IMessageService implementation

        public async System.Threading.Tasks.Task ShowAsync(string message)
        {
            await FazBem.App.Current.MainPage.DisplayAlert("Faz bem", message, "ok");
        }

        public void Show(string message)
        {
            FazBem.App.Current.MainPage.DisplayAlert("Faz bem", message, "ok");
        }

        #endregion

        public MessageService()
        {
        }
    }
}
