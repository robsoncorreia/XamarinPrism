
using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;

namespace XamarinPrism.ViewModels.Login
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Login";
        }
    }
}
