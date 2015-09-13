using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.ViewModels.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
        void Show(string message);
    }
}
