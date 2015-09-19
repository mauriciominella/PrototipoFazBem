using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FazBem.Models;
using Xamarin.Forms;
using FazBem.Interfaces;

namespace FazBem.Views.Services
{
    public class NavigationService : ViewModels.Services.INavigationService
    {
        public async System.Threading.Tasks.Task NavigateToLogin()
        {
            throw new NotImplementedException();
            //await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.LoginView());
        }

        public async System.Threading.Tasks.Task NavigateToProductDetail(Product product)
        {
			var view = new Views.ProductDetailView ();
			
			SetViewModelParameter (product, view);

			await FazBem.App.Current.MainPage.Navigation.PushAsync(view);
        }

		public async System.Threading.Tasks.Task NavigateToCamera()
		{
			await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.CameraView());
		}

		public async System.Threading.Tasks.Task NavigateToProductComment()
		{
			await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.ProductCommentsView());
		}

		private void SetViewModelParameter (object product, ContentPage view)
		{
			if (view.BindingContext is IInitializableViewModel) {
				((IInitializableViewModel)view.BindingContext).Init (product);
			}
		}

    }
}
