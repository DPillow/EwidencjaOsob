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

            Console.WriteLine("Witam w programie ewidencji zleceń.");
            Console.WriteLine("Proszę o wybranie odpowiedniej czynności:");

            var mainMenu = actionService.GetMenuActionsByName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            JobService jobService = new JobService();
            switch(operation.KeyChar)
            {
                case '1':
                    var keyInfo = jobService.AddNewJobView(actionService);
                    jobService.AddNewJob(keyInfo.KeyChar);
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                default:
                    Console.WriteLine("Wybrano błędną akcję");
                    break;
           
            }




        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Dodaj zlecenie", "Main");
            actionService.AddNewAction(2, "Usuń zlecenie", "Main");
            actionService.AddNewAction(3, "Wyszukaj zlecenie", "Main");
            actionService.AddNewAction(4, "Szukaj po osobie", "Main");

            actionService.AddNewAction(1, "Podział", "AddNewJobMenu");
            actionService.AddNewAction(2, "Mapa do celów projektowych", "AddNewJobMenu");
            actionService.AddNewAction(3, "Inwentaryzacja", "AddNewJobMenu");
            actionService.AddNewAction(4, "Obsługa", "AddNewJobMenu");

            return actionService;
        }

    }
}