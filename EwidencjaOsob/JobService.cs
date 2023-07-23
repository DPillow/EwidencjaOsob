using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EwidencjaZlecen
{
    internal class JobService
    {
        public List<Job> Jobs { get; set; }
        public JobService() 
        {
            Jobs = new List<Job>();
        }

        public ConsoleKeyInfo AddNewJobView(MenuActionService actionService)
        {
            Console.WriteLine("Proszę o wybranie kategorii roboty:");
            var addJobMenu = actionService.GetMenuActionsByName("AddNewJobMenu");
            for (int i = 0; i < addJobMenu.Count; i++)
            {
                Console.WriteLine($"{addJobMenu[i].Id}. {addJobMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;

        }

        public void AddNewJob(char jobType)
        {

        }

    }
}
