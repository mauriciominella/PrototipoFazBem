using System;
using FazBem.ViewModels;
using System.Collections.Generic;
using FazBem.Models;
using Xamarin.Forms;
using System.Windows.Input;

namespace FazBem.ViewModels
{
	public class FindYourProfileViewModel : ViewModelBase
	{
		#region Attributes

		private string _lactoseImage;

		#endregion

		#region Properties

		public string MainText { get; protected set; }

		public string Description { get; set; }

		public string LactoseImage {
			get {
				return _lactoseImage;
			}
			set {
				_lactoseImage = value;
				Notify ();
			}
		}

		public ICommand OpenCameraCommand {
			get;
			set;
		}


		public IList<EnumProfile> Profiles { get; protected set; }

		#endregion
		
		public FindYourProfileViewModel ()
		{
			MainText = "Bem vindo ao FazBemApp!";
			Description = "Escolha o seu perfil:";
			LactoseImage = "LactoseGreen.png";

			Profiles = new List<EnumProfile> ();

			this.OpenCameraCommand = new Command (OpenCamera);
		}

		private void OpenCamera(){
			_navigationService.NavigateToCamera ();
		}
	}
}