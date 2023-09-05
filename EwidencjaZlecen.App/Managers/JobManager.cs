using EwidencjaZlecen.App.Abstract;
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
        private IService<Job> _jobService;

        public JobManager(MenuActionService actionService, IService<Job> jobService)
        {
            _actionService = actionService;
            _jobService = jobService;
        }
        public int AddNewItem()
        {
            var addNewJobMenu = _actionService.GetMenuActionsByName("AddNewJobMenu");
            Console.WriteLine("Please select job type:");
            for (int i = 0; i < addNewJobMenu.Count; i++)
            {
                Console.WriteLine($"{addNewJobMenu[i].Id}. {addNewJobMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("Please insert name for job:");
            var name = Console.ReadLine();
            var lastId = _jobService.GetLastId();
            Job job = new Job(lastId + 1, name, typeId);
            _jobService.AddItem(job);
            return job.Id;
        }

        public void RemoveJobById(int id)
        {
            var item = _jobService.GetItemById(id);
            _jobService.RemoveItem(item);
        }

        public Job GetItemById(int id)
        {
            var item = _jobService.GetItemById(id);
            return item;
        }


    }
}
