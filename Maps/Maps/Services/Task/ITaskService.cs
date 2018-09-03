using Maps.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Maps.Services
{
    public interface ITaskService
    {
        Task<ObservableCollection<TaskStep>> Get();
    }
}
