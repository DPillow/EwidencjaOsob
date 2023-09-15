using EwidencjaZlecen.App.Abstract;
using EwidencjaZlecen.App.Concrete;
using EwidencjaZlecen.Domain.Entity;
using EwidencjaZlecen.App.Managers;
using System;
using EwidencjaZlecen.App.Common;

namespace EwidencjaZlecen
{

    //TODO
    //szukanie niech ma warunek żeby nie wywalało exception
    //Dodać funkcję sprawdzającą czy jest po terminie
    //Sprawdzić implementację dat, bo wydaje mi się że źle zaciąga
    //Dodać szukanie po kliencie, zrobić żeby nie było case sensitive
    //Dodać statusy zlecenia (zakończone, przyjęte, rozpoczęte prace, ...)
    //lista robót
    //Przy dodawaniu roboty dawać zwrotnie jakie ID zostało nadane

    //w późniejszym etapie spięcie z bazą danych
    //ładne GUI do obsługi
    //możliwość generowania umów w wordzie z template, pism innych, itp. zaciągając z bazy danych. (tutaj visal basic nie trzeba przypadkiem?)
    //podpinanie dokumentów pod zlecenie


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
                        var newId = jobManager.AddNewJob();
                        break;
                    case '2':
                        Console.WriteLine("");
                        Console.WriteLine("Proszę o wpisanie id zlecenia do usunięcia: ");
                        Int32.TryParse(Console.ReadLine(), out int inputId);
                        jobManager.RemoveJobById(inputId);
                        break;
                    case '3':
                        Console.WriteLine("");
                        Console.WriteLine("Proszę o wpisanie id zlecenia do wyszukania: ");
                        Int32.TryParse(Console.ReadLine(), out int searchId);
                        var jobFound = jobManager.GetJobById(searchId);
                        Console.WriteLine($"Robota o ID: {jobFound.Id} i nazwie {jobFound.Name} wykonywana jest dla {jobFound.Client} i została ostatnio zmodyfikowana {jobFound.UpdatedDateTime}");//tutaj do walnięcia check jeżeli nie ma zamiast crashu programu
                        break;
                    case '4':
                        Console.WriteLine("");
                        Console.WriteLine("Proszę o wpisanie klienta do wyszukania zlecenia: ");
                        string searchClient = Console.ReadLine();
                        var jobFoundByClient = jobManager.GetItemByClient(searchClient);
                        Console.WriteLine($"Robota o ID: {jobFoundByClient.Id} i nazwie {jobFoundByClient.Name} wykonywana jest dla {jobFoundByClient.Client} i została ostatnio zmodyfikowana {jobFoundByClient.UpdatedDateTime}");//Jak wprowadzić żeby kilka znajdowało
                        break;
                    case '5':
                        //Console.WriteLine(""); //Lista robót
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