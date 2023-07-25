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

        public int AddNewJob(char jobType)
        {
            int jobTypeId;
            Int32.TryParse(jobType.ToString(), out jobTypeId);
            Job job = new Job();
            job.TypeId = jobTypeId;
            Console.WriteLine("Proszę o podanie ID roboty");
            var id = Console.ReadLine();
            int jobId;
            Int32.TryParse(id, out jobId);
            Console.WriteLine("Proszę o podanie nazwy roboty");
            var name = Console.ReadLine();
            Console.WriteLine("Proszę o podanie klienta");
            var client = Console.ReadLine();
            var date = DateTime.Today.ToString("dd/MM/yyyy");

            job.Id = jobId;
            job.Name = name;
            job.Client = client;
            job.ModifyDate = date;
            Jobs.Add(job);
            return jobId;

        }

        public int RemoveJobView()
        {
            Console.WriteLine("Proszę o wskazanie ID roboty do usunięcia");
            var action = Console.ReadLine();
            Int32.TryParse(action.ToString(), out int id);
            return id;
        }

        public void RemoveJob(int removeId)
        {
            Job jobToRemove = new Job(); //Inicjalizujemy produkt żeby nie wywaliło null
            foreach (var job in Jobs)
            {
                if (job.Id == removeId)
                {
                    jobToRemove = job;
                    break;
                }
            }
            Jobs.Remove(jobToRemove);
            Console.WriteLine($"Robota o ID: {removeId} została usunięta");
        }

        public int SearchJobByIdView()
        {
            Console.WriteLine("Proszę o wskazanie ID roboty do odnalezienia");
            var actionSearch = Console.ReadLine();
            Int32.TryParse(actionSearch.ToString(), out int id);
            return id;
        }
        public void SearchJobById(int searchJob)
        {
            Job jobToFind = new Job(); //Inicjalizujemy produkt żeby nie wywaliło null
            foreach (var job in Jobs)
            {
                if (job.Id == searchJob)
                {
                    jobToFind = job;
                    break;
                }
            }
            Console.WriteLine($"Robota o ID: {jobToFind.Id} i nazwie {jobToFind.Name} wykonywana jest dla {jobToFind.Client} i została ostatnio zmodyfikowana {jobToFind.ModifyDate}");
        }

        public string SearchJobByClientView()
        {
            Console.WriteLine("Proszę o wpisanie nazwiska i imienia klienta do odnalezienia");
            string actionSearch = Console.ReadLine();
            return actionSearch;
        }
        public void SearchJobByClient(string searchJobClient)
        {
            Job jobToFindClient = new Job(); //Inicjalizujemy produkt żeby nie wywaliło null
            foreach (var job in Jobs)
            {
                if (job.Client == searchJobClient)
                {
                    jobToFindClient = job;
                    Console.WriteLine($"Robota o ID: {jobToFindClient.Id} i nazwie {jobToFindClient.Name} wykonywana jest dla {jobToFindClient.Client} i została ostatnio zmodyfikowana {jobToFindClient.ModifyDate}");
                }
            }
        }

        public void ListJobs()
        {
            Job listOfJobs = new Job();
            foreach (var job in Jobs)
            {
                listOfJobs = job;
                Console.WriteLine($"Robota o ID: {listOfJobs.Id} i nazwie {listOfJobs.Name} wykonywana jest dla {listOfJobs.Client} i została ostatnio zmodyfikowana {listOfJobs.ModifyDate}");
            }

        }
    }
}
