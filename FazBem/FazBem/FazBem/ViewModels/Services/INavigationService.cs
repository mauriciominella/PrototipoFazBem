using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FazBem.Models;

namespace FazBem.ViewModels.Services
{
    public interface INavigationService
    {
        Task NavigateToLogin();

		Task NavigateToProductDetail(Product product);

		Task NavigateToCamera();

		Task NavigateToProductComment();
    }
}
