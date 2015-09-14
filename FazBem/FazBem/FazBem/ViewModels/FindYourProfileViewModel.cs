using System;
using FazBem.ViewModels;
using System.Collections.Generic;
using FazBem.Models;
using Xamarin.Forms;
using System.Reflection;
using System.Windows.Input;

namespace FazBem.ViewModels
{
	public class FindYourProfileViewModel : ViewModelBase
	{
		#region Attributes

		private string _lactoseImage;
		private string _wheatImage;
		private string _veganImage;

		private ICommand _lactoseCommand;
		private ICommand _wheatCommand;
		private ICommand _veganCommand;

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

		public string WheatImage {
			get {
				return _wheatImage;
			}
			set {
				_wheatImage = value;
				Notify ();
			}
		}

		public string VeganImage {
			get {
				return _veganImage;
			}
			set {
				_veganImage = value;
				Notify ();
			}
		}

		public ICommand LactoseCommand {
			get {
				return _lactoseCommand;
			}
		}

		public ICommand WheatCommand {
			get {
				return _wheatCommand;
			}
		}

		public ICommand VeganCommand { 
			get {
				return _veganCommand;
			}
		}

		public ICommand OpenCameraCommand {
			get;
			set;
		}

		public IList<EnumProfile> Profiles { get; protected set; }

		#endregion
		
		#region Constructors

		public FindYourProfileViewModel ()
		{
			MainText = "Bem vindo ao FazBemApp!";
			Description = "Escolha o seu perfil:";

			LactoseImage = FazBem.Resources.Images.LactoseNeutral;
			WheatImage = FazBem.Resources.Images.WheatNeutral;
			VeganImage = FazBem.Resources.Images.VeganNeutral;

			_lactoseCommand = new Command<EnumProfile> (HandleCommands);
			_wheatCommand = new Command<EnumProfile> (HandleCommands);
			_veganCommand = new Command<EnumProfile> (HandleCommands);

			Profiles = new List<EnumProfile> ();

			this.OpenCameraCommand = new Command (OpenCamera);
		}

		private void OpenCamera(){
			_navigationService.NavigateToCamera ();
		}
			
		#endregion

		#region Methods

		protected void HandleCommands (EnumProfile profile)
		{	
			FieldInfo fieldImageResource;
			string propertyName;
			string imageNameConstant;

			if (Profiles.Contains (profile)) 
			{
				Profiles.Remove (profile);
				imageNameConstant = String.Format ("{0}{1}", profile, "Neutral");
			} else 
			{
				Profiles.Add (profile);
				imageNameConstant = String.Format ("{0}{1}", profile, "Green");
			}

			propertyName = String.Format ("{0}{1}", profile, "Image");
			fieldImageResource = typeof(FazBem.Resources.Images).GetRuntimeField (imageNameConstant);

			this.GetType().GetRuntimeProperty(propertyName).SetValue(this, fieldImageResource.GetValue(null));
		}

		#endregion
	}
}