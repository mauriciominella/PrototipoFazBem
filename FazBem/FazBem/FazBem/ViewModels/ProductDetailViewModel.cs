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
			
		public ProductDetailViewModel()
		{
			this.Ratings = new ObservableCollection<UserRating> ();

			FetchData ();
		}

        public ObservableCollection<UserRating> Ratings { get; set; }

        public Product ProductToBeRated { get; set; }

        public ICommand LikeCommand { get; set; }

        public ICommand UnlinkeCommand { get; set; }

        public ICommand OpenCameraCommand { get; set; }

		void FetchData ()
		{
			ProductToBeRated = new Product () {
				Name = "Bolacha Maria"
			};
			User user = new User () {
				Name = "Mauricio Minella"
			};
			user.Profiles.Add (EnumProfile.Gluten);
			user.Profiles.Add (EnumProfile.Lactose);

            foreach (var item in user.Profiles)
            {
                this.Ratings.Add(new UserRating()
                {
                    Product = ProductToBeRated,
                    User = user,
                    Profile = item
                });
            }
		
		}
    }
}
