using EwidencjaZlecen.App.Abstract;
using EwidencjaZlecen.App.Concrete;
using EwidencjaZlecen.Domain.Entity;
using EwidencjaZlecen.App.Managers;

namespace EwidencjaZlecen
{

    //TODO
    //DODAWANIE FUNKCJONALNOŚCI
    //POMYŚLEĆ W KTÓRĄ STRONĘ ROZWIJAĆ 
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            JobService jobService = new JobService();
            JobManager jobManager = new JobManager(actionService, jobService);


            Console.WriteLine("Witam w programie ewidencji zleceń.");
            while (true)
            {
                Console.WriteLine("Proszę o wybranie odpowiedniej czynności:");

                var mainMenu = actionService.GetMenuActionsByName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();

                switch (operation.KeyChar)
                {
                    case '0':
                        Environment.Exit(0);
                        break;
                    case '1':
                        Console.WriteLine("");
                        var newId = jobManager.AddNewItem();
                        break;
                    case '2':
                        //Console.WriteLine("");
                        //var removeId = jobService.RemoveJobView();
                        //jobService.RemoveJob(removeId);
                        //break;
                    case '3':
                        //Console.WriteLine("");
                        //var searchJob = jobService.SearchJobByIdView();
                        //jobService.SearchJobById(searchJob);
                        //break;
                    case '4':
                        //Console.WriteLine("");
                        //var searchJobClient = jobService.SearchJobByClientView();
                        //jobService.SearchJobByClient(searchJobClient);
                        //break;
                    case '5':
                        //Console.WriteLine("");
                        //jobService.ListJobs();
                        //break;
                    default:
                        Console.WriteLine("Wybrano błędną akcję");
                        break;
                }
            }
        }
        

    }
}