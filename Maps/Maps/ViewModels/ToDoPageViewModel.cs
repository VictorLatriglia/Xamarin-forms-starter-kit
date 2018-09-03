using Maps.Models;
using Maps.Services;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Maps.ViewModels
{
    public class ToDoPageViewModel : ViewModelBase, INavigatedAware
    {
        private readonly ITaskService taskService;

        private ObservableCollection<TaskStep> _steps;
        public ObservableCollection<TaskStep> Steps
        {
            get { return _steps; }
            set
            {
                _steps = value;
                RaisePropertyChanged(() => Steps);
            }
        }

        private DateTime _today;
        public DateTime Today
        {
            get { return _today; }
            set
            {
                _today = value;
                RaisePropertyChanged(() => Today);
            }
        }

        public ToDoPageViewModel(INavigationService navigationService, ITaskService taskService)
            : base(navigationService)
        {
            this.taskService = taskService;
        }

        public override async Task InitializeAsync(object navigationData)
        {
            Today = DateTime.Now;
            GetData();
        }

        private void GetData()
        {
            Steps = taskService.Get();
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            InitializeAsync(null);
        }
    }
}
