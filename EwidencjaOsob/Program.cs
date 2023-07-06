namespace EwidencjaOsob
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

            Console.WriteLine("Witam w programie ewidencji osób.");
            Console.WriteLine("Proszę o wybranie odpowiedniej czynności:");

            var mainMenu = actionService.GetMenuActionsByName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }
            var operation = Console.ReadKey();






        }
        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Dodaj osobę", "Main");
            actionService.AddNewAction(2, "Usuń osobę", "Main");
            actionService.AddNewAction(3, "Wyszukaj osobę", "Main");
            actionService.AddNewAction(4, "Szukaj po jednostce rejestrowej", "Main");
            return actionService;
        }

    }
}