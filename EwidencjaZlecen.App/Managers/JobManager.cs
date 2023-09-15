using EwidencjaZlecen.App.Abstract;
using EwidencjaZlecen.App.Common;
using EwidencjaZlecen.App.Concrete;
using EwidencjaZlecen.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwidencjaZlecen.App.Managers
{
    public class JobManager
    {
        private readonly MenuActionService _actionService;
        private JobService _jobService;

        public JobManager(MenuActionService actionService, JobService jobService)
        {
            _actionService = actionService;
            _jobService = jobService;
        }
        public int AddNewJob()
        {
            var addNewJobMenu = _actionService.GetMenuActionsByName("AddNewJobMenu");
            Console.WriteLine("");
            Console.WriteLine("Proszę o wybranie typu roboty:");
            for (int i = 0; i < addNewJobMenu.Count; i++)
            {
                Console.WriteLine($"{addNewJobMenu[i].Id}. {addNewJobMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("");
            Console.WriteLine("Proszę o wybranie nazwy roboty:");
            var name = Console.ReadLine();
            var lastId = _jobService.GetLastId();
            Console.WriteLine("");
            Console.WriteLine("Proszę o podanie klienta:");
            var client = Console.ReadLine();
            int newId = lastId + 1;
            Job job = new Job(newId, name, typeId, client);
            _jobService.AddItem(job);
            return job.Id;
        }

        public void RemoveJobById(int id)
        {
            var job = _jobService.GetItemById(id);
            _jobService.RemoveItem(job);
            Console.WriteLine($"Robota o ID: {id} została usunięta");
        }

        public Job GetJobById(int id)
        {
            var job = _jobService.GetItemById(id);
            return job;
        }

        public List<Job> GetItemByClient(string searchClient)
        {
            var job = _jobService.GetItemByClient(searchClient);
            return job;
        }
    }
}
