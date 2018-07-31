using Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core
{
	public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {
        }

        protected override void NavigateToFirstViewModel(object hint = null)
        {
            NavigationService.Navigate<FirstViewModel>();
        }
    }
}