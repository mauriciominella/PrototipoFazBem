using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.ViewModels.Services
{
    public interface INavigationService
    {
        Task NavigateToLogin();

        Task NavigateToProductDetail();

		Task NavigateToCamera();

		Task NavigateToProductComment();
    }
}
