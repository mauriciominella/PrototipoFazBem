﻿using FazBem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FazBem.Interfaces;
using FazBem.Services;

namespace FazBem.ViewModels
{
	public class ProductDetailViewModel : ViewModelBase, IInitializableViewModel
    {
		#region IParametrizedViewModel implementation

		public void Init (object data)
		{
			if (data != null && data is Product) {
				this.ProductToBeRated = (Product)data;

				this.ProductToBeRated = _productService.GetByBardCode (this.ProductToBeRated.BarCode);

				FetchData ();
			}
		}

		#endregion

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

		string productDescription = "";
		public string ProductDescription {
			get {
				return productDescription;
			}
			set {
				productDescription = value;
				Notify ("ProductDescription");
			}
		}

		ProductRating selectedProductRating;
		public ProductRating SelectedProductRating {
			get {
				return selectedProductRating;
			}
			set {
				selectedProductRating = value;
				Notify ("SelectedProductRating");
			}
		}

		private IProductService _productService = null;

		public ProductDetailViewModel()
		{
			_productService = DependencyService.Get<IProductService> ();

			this.ProductRatings = new ObservableCollection<ProductRating> ();

			this.LikeCommand = new Command<ProductRating> (p => Like(p));
			this.UnlikeCommand = new Command<ProductRating> (p => Unlike(p));
			this.ProductCommentsCommand = new Command (ProductComments);
			this.ScanProductCommand = new Command (ScanProduct);
		}

		private void ScanProduct(){
			_navigationService.NavigateToCamera ();
		}

        public ObservableCollection<ProductRating> ProductRatings { get; set; }

        public Product ProductToBeRated { get; set; }

		ICommand likeCommand;
        public ICommand LikeCommand {
			get {
				return likeCommand;
			}
			set {
				likeCommand = value;
			}
		}

		ICommand unlinkeCommand;
        public ICommand UnlikeCommand {
			get {
				return unlinkeCommand;
			}
			set {
				unlinkeCommand = value;
			}
		}

		ICommand scanProductCommand;
        public ICommand ScanProductCommand {
			get {
				return scanProductCommand;
			}
			set {
				scanProductCommand = value;
			}
		}

		ICommand productCommentsCommand;
		public ICommand ProductCommentsCommand {
			get {
				return productCommentsCommand;
			}
			set {
				productCommentsCommand = value;
			}
		}


		void Like(ProductRating productRating){
			productRating.LikeCount++;
			Notify ("ProductRatings");
		}

		void Unlike(ProductRating productRating){
			productRating.UnlikeCount++;
			Notify ("ProductRatings");
		}

		void ProductComments(){
			_navigationService.NavigateToProductComment ();
		}

		void FetchData ()
		{
			User user = new User () {
				Name = "Mauricio Minella"
			};

			this.ProductDescription = ProductToBeRated.Name;

			user.Profiles = EnumProfile.Wheat | EnumProfile.Lactose;

            foreach (EnumProfile item in GetFlags(user.Profiles))
            {
                this.ProductRatings.Add(new ProductRating()
                {
                    Product = ProductToBeRated,
                    Profile = item,
					LikeCount = 10,
					UnlikeCount = 11,
                });
            }
		}
		
        static IEnumerable<Enum> GetFlags(Enum input)
        {
            foreach (Enum value in Enum.GetValues(input.GetType()))
                if (input.HasFlag(value))
                    yield return value;
		}
    }
}
