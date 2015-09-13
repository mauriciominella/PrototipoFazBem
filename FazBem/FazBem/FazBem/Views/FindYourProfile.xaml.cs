using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;
using XLabs.Enums;

namespace FazBem.Views
{
	public partial class FindYourProfile : ContentPage
	{
		public FindYourProfile ()
		{
			InitializeComponent ();

			BindingContext = new ViewModels.FindYourProfileViewModel ();
		}
	}
}

