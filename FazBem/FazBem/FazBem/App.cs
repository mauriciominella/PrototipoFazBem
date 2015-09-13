using FazBem.Models;
using FazBem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FazBem
{
    public class App : Application
    {
        public App()
        {
            DependencyService.Register<ViewModels.Services.IMessageService, Views.Services.MessageService>();
            DependencyService.Register<ViewModels.Services.INavigationService, Views.Services.NavigationService>();
            DependencyService.Register<IUserRepository, UserRepository>();

            var user = new User
            {
                Name = "Rodrigo Wirth",
                Profiles = EnumProfile.Gluten | EnumProfile.Lactose
            };
		
            IUserRepository userRepository = DependencyService.Get<IUserRepository>();

            var users = userRepository.List();
            if (users.Count == 0)
                MainPage = new NavigationPage(new FazBem.Views.FindYourProfile());
            else
                MainPage = new NavigationPage(new FazBem.Views.CameraView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
