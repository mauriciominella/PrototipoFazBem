using FazBem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FazBem.Views
{
    public partial class ProductDetailView : ContentPage
    {
        public ProductDetailView()
        {
            InitializeComponent();

            this.BindingContext = new ProductDetailViewModel();
        }
    }
}
