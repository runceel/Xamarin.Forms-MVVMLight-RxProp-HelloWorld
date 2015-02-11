using App13.ViewModels;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    public static class ViewModelLocator
    {
        static ViewModelLocator()
        {
            var c = new UnityContainer();
            ServiceLocator.SetLocatorProvider(new ServiceLocatorProvider(() => new UnityServiceLocator(c)));
        }

        public static MainViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }
    }
}
