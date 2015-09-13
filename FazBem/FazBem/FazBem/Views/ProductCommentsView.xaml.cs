using System;
using System.Collections.Generic;

using Xamarin.Forms;
using FazBem.ViewModels;

namespace FazBem.Views
{
	public partial class ProductCommentsView : ContentPage
	{
		public ProductCommentsView ()
		{
			InitializeComponent ();
			this.BindingContext = new ProductCommentsViewModel();
		}
	}
}

