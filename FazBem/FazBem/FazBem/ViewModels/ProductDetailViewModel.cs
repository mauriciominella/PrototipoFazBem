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
        public ObservableCollection<UserRating> Ratings { get; set; }

        public Product ProductToBeRated { get; set; }

        public ICommand LikeCommand { get; set; }

        public ICommand UnlinkeCommand { get; set; }

    }
}
