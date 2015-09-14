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

			if (value is UserRating) {

                UserRating userRating = (UserRating)value;

                switch (userRating.Profile)
                {
                    case EnumProfile.Lactose:
                        break;
                    case EnumProfile.Wheat:
                        break;
                    case EnumProfile.Vegan:
                        break;
                    default:
                        break;
                }
            }

			throw new NotImplementedException ();
		}
		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
		
	}
}

