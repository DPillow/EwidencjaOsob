namespace EwidencjaZlecen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Przywitanie
            //Wybór akcji
            ////a. dodanie osoby
            ////b. usuniecie osoby
            ////c. Wyszukanie danych osoby
            ////d. szukanie po jednostce rej. (filtr)
            ///
            //TODO Potem
            //// Dodanie działek ewid. do jednostki (już baza danych lepiej?)
            //// dodanie punktów do działki 

            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            JobService jobService = new JobService();

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
                        var keyInfo = jobService.AddNewJobView(actionService);
                        Console.WriteLine("");
                        var id = jobService.AddNewJob(keyInfo.KeyChar);
                        break;
                    case '2':
                        Console.WriteLine("");
                        var removeId = jobService.RemoveJobView();
                        jobService.RemoveJob(removeId);
                        break;
                    case '3':
                        Console.WriteLine("");
                        var searchJob = jobService.SearchJobByIdView();
                        jobService.SearchJobById(searchJob);
                        break;
                    case '4':
                        Console.WriteLine("");
                        var searchJobClient = jobService.SearchJobByClientView();
                        jobService.SearchJobByClient(searchJobClient);
                        break;
                    case '5':
                        Console.WriteLine("");
                        jobService.ListJobs();
                        break;
                    default:
                        Console.WriteLine("Wybrano błędną akcję");
                        break;
                }
            }




        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Dodaj zlecenie", "Main");
            actionService.AddNewAction(2, "Usuń zlecenie", "Main");
            actionService.AddNewAction(3, "Wyszukaj zlecenie", "Main");
            actionService.AddNewAction(4, "Szukaj po kliencie", "Main");
            actionService.AddNewAction(5, "Lista robót", "Main");
            actionService.AddNewAction(0, "Wyjście z programu", "Main");

            actionService.AddNewAction(1, "Podział", "AddNewJobMenu");
            actionService.AddNewAction(2, "Mapa do celów projektowych", "AddNewJobMenu");
            actionService.AddNewAction(3, "Inwentaryzacja", "AddNewJobMenu");
            actionService.AddNewAction(4, "Obsługa", "AddNewJobMenu");

            return actionService;
        }

    }
}