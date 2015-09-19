using System;
using Xamarin.Forms;

namespace FazBem
{
	public abstract class ViewBase : ContentPage
	{


		protected override void OnDisappearing()
		{
			UnsubscribeFromMessages();
			base.OnDisappearing();

		}

		private void UnsubscribeFromMessages ()
		{
			MessagingCenter.Unsubscribe<NavigationMessage> (this, enumNavigationMessage.ShowTargetView.ToString ());

		}

		public abstract void Navigate(object data);
		public abstract void Navigate();

	}
}

