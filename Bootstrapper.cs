using Caliburn.Micro;
using CMCalcculator.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace CMCalcculator
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            await DisplayRootViewForAsync(typeof(ShellViewModel));
        }


    }
}
