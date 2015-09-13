using System;
using FazBem.Models;
using System.ComponentModel;

namespace FazBem.Models
{
	public class ProductRating : INotifyPropertyChanged
	{
		EnumProfile profile;
		public EnumProfile Profile {
			get {
				return profile;
			}
			set {
				profile = value;
				Notify ("Profile");
			}
		}

		Product product;
		public Product Product {
			get {
				return product;
			}
			set {
				product = value;
				Notify ("Product");
			}
		}

		int likeCount;
		public int LikeCount {
			get {
				return likeCount;
			}
			set {
				likeCount = value;
				Notify ("LikeCount");
			}
		}

		int unlikeCount;
		public int UnlikeCount {
			get {
				return unlikeCount;
			}
			set {
				unlikeCount = value;
				Notify ("UnlikeCount");
			}
		}


		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		protected void Notify(string propertyName)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

