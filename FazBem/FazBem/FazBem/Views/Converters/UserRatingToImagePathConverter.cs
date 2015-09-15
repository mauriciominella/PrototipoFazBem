using System;
using Xamarin.Forms;
using FazBem.Models;

namespace FazBem.Views.Converters
{
	public class UserRatingToImagePathConverter : IValueConverter
	{
		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			string imagePath = "LactoseNeutral.png";

			string imagePrefix = "";
			string imageColor = "";

			if (value is ProductRating) {

				ProductRating productRating = (ProductRating)value;

				imagePrefix = productRating.Profile.ToString ();

				if (productRating.LikeCount <= 0 || productRating.UnlikeCount <= 0)
					imageColor = "Neutral";


				if (productRating.LikeCount > productRating.UnlikeCount)
					imageColor = "Green";
				else if (productRating.LikeCount < productRating.UnlikeCount)
					imageColor = "Red";
				else
					imageColor = "Neutral";
            }

			return imagePrefix + imageColor + ".png";
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
		
	}
}

