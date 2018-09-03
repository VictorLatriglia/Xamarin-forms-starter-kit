using Maps.Extensions;
using Maps.Models;
using Maps.Services.RequestProvider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Maps.Services
{
    public class TaskService : BaseService, ITaskService
    {
        public TaskService(IRequestProvider requestProvider)
            : base(requestProvider)
        {

        }

        public async Task<ObservableCollection<TaskStep>> Get()
        {
            var localsteps = CreateData();
            localsteps.AddRange((await GetRemote()));
            FindLastItem(localsteps);
            return localsteps.ToObservableCollection();
        }

        private List<TaskStep> CreateData()
        {
            return new List<TaskStep>
            {
                new TaskStep
                {
                    Title="Write some code",
                    Description="It aint gonna write itself!",
                    IsCompleted = true
                },
                new TaskStep
                {
                    Title="Drink some cofee",
                    Description="Yeah, you've already drink, but what about some more?",
                    IsCompleted = true
                },
                new TaskStep
                {
                    Title="Publish",
                    Description="Thank you Victor, very cool!",
                    IsCompleted = true
                },
                new TaskStep
                {
                    Title="Add some more task",
                    Description="It is up to you now buddy",
                    IsCompleted = false
                },
                new TaskStep
                {
                    Title="Use the template",
                    Description="Do something awesome and make me proud :)",
                    IsCompleted = false
                }
            };
        }

        private async Task<IEnumerable<TaskStep>> GetRemote()
        {
            UriBuilder builder = new UriBuilder(GlobalSetting.DefaultEndpoint)
            {
                Path = "api/Tasks/Steps"
            };
            try
            {
                var remoteSteps = await _requestProvider.GetAsync<IEnumerable<TaskStep>>(builder.ToString());
                return remoteSteps;
            }
            catch
            {
                return new List<TaskStep>();
            }
        }

        private void FindLastItem(IEnumerable<TaskStep> steps)
        {
            var lastItem = steps.LastOrDefault();
            lastItem.IsLast = true;
        }
    }
}
