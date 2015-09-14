using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.Views.Services
{
    public class NavigationService : ViewModels.Services.INavigationService
    {
        public async System.Threading.Tasks.Task NavigateToLogin()
        {
            throw new NotImplementedException();
            //await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.LoginView());
        }

        public async System.Threading.Tasks.Task NavigateToProductDetail()
        {
            await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.ProductDetailView());
        }

		public async System.Threading.Tasks.Task NavigateToCamera()
		{
			await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.CameraView());
		}

		public async System.Threading.Tasks.Task NavigateToProductComment()
		{
			await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.ProductCommentsView());
		}

    }
}
