using FazBem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections;
using System.ComponentModel;

namespace FazBem.ViewModels
{
	public class ProductCommentsViewModel : ViewModelBase
	{
		public ProductCommentsViewModel (Product product, IList UserRatings)
		{
		}

		public ProductCommentsViewModel()
		{
			
			ProductDisplayed = new Product()
			{
				Name = "Bolacha Maria"
			};

			UserRatings = new ObservableCollection<UserRating>();

			this.Test = "This is a test";
		
			/*UserRatings.Add(new UserRating(){
				Id="1",
				Like = true,
				Comment="Me fez super bem",
				Profile=EnumProfile.Lactose,
				User=new User(){
					Id="1",
					Name="Zé Carioca",
					Profiles={EnumProfile.Lactose,EnumProfile.Gluten }
				}
			});
				
			UserRatings.Add (new UserRating () {
				Id = "21",
				Like = true,
				Comment = "Gostei do produto sem lactose",
				Profile = EnumProfile.Lactose,
				User = new User () {
					Id = "21",
					Name = "Zé Colméia",
					Profiles = { EnumProfile.Lactose, EnumProfile.Gluten }
				}
			});*/
		}

		string _test;
		public string Test {
			get{
				return _test;
			}
			set {
				_test = value;
				base.Notify ("Test");
					
				}
		}

		public Product ProductDisplayed { get; set; }
		public ObservableCollection<UserRating> UserRatings { get; set; }
	}
}