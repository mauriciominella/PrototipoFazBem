﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.Views.Services
{
    public class NavigationService : ViewModels.Services.INavigationService
    {
        public async System.Threading.Tasks.Task NavigateToLogin()
        {
            throw new NotImplementedException();
            //await FazBem.App.Current.MainPage.Navigation.PushAsync(new Views.LoginView());
        }

    }
}