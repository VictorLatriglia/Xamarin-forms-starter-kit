using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Maps.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand NavigateToPageCommand => new Command(NavigateToPage);
        public ICommand DeveloperPageCommand => new Command(DeveloperPage);
        public ICommand CompanyPageCommand => new Command<string>(CompanyPage);

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        private void DeveloperPage()
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/in/victor-latriglia-3b6328155/"));
        }

        private void CompanyPage(string webType)
        {
            if (webType.Equals("WebSite"))
            {
                Device.OpenUri(new Uri("http://www.creapps.co/"));
            }
            if (webType.Equals("LinkedIn"))
            {
                Device.OpenUri(new Uri("https://www.linkedin.com/company/creapps-soluciones/"));
            }
        }

        private void NavigateToPage(object obj)
        {
            NavigationService.NavigateAsync(new Uri("ToDoPage", UriKind.Relative));
        }
    }
}
