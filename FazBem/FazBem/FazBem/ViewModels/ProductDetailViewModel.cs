using FazBem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FazBem.ViewModels
{
    public class ProductDetailViewModel : ViewModelBase
    {
		bool isLoading;
		public bool IsLoading {
			get {
				return isLoading;
			}
			set {
				isLoading = value;
				Notify ("IsLoading");
			}
		}

		public ProductDetailViewModel(){

			ProductToBeRated = new Product()
			{
				Name = "Bolacha Maria"
			};


			this.Ratings = new ObservableCollection<UserRating> ();
		}

        public ObservableCollection<UserRating> Ratings { get; set; }

        public Product ProductToBeRated { get; set; }

        public ICommand LikeCommand { get; set; }

        public ICommand UnlinkeCommand { get; set; }

        public ICommand OpenCameraCommand { get; set; }


    }
}
