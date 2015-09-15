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
				Notify ("ImagePath");
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
				Notify ("ImagePath");
			}
		}

		public string ImagePath {
			get {
				return GetImagePath ();
			}
		}

		private string GetImagePath(){
			
			string imagePath = "LactoseNeutral.png";

			string imagePrefix = "";
			string imageColor = "";

			imagePrefix = this.Profile.ToString ();

			if (this.LikeCount <= 0 || this.UnlikeCount <= 0)
				imageColor = "Neutral";

			if (this.LikeCount > this.UnlikeCount)
				imageColor = "Green";
			else if (this.LikeCount < this.UnlikeCount)
				imageColor = "Red";
			else
				imageColor = "Neutral";

			return imagePrefix + imageColor + ".png";
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

