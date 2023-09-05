using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EwidencjaZlecen.App.Common;
using EwidencjaZlecen.Domain.Entity;
using EwidencjaZlecen.Domain.Common;

namespace EwidencjaZlecen.App.Concrete
{
    public class MenuActionService : BaseService <MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }

        public List<MenuAction> GetMenuActionsByName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

        private void Initialize()
        {
            AddItem(new MenuAction(1, "Dodaj zlecenie", "Main"));
            AddItem(new MenuAction(2, "Usuń zlecenie", "Main"));
            AddItem(new MenuAction(3, "Wyszukaj zlecenie", "Main"));
            AddItem(new MenuAction(4, "Szukaj po kliencie", "Main"));
            AddItem(new MenuAction(5, "Lista robót", "Main"));
            AddItem(new MenuAction(0, "Wyjście z programu", "Main"));

            AddItem(new MenuAction(1, "Podział", "AddNewJobMenu"));
            AddItem(new MenuAction(2, "Mapa do celów projektowych", "AddNewJobMenu"));
            AddItem(new MenuAction(3, "Inwentaryzacja", "AddNewJobMenu"));
            AddItem(new MenuAction(4, "Obsługa", "AddNewJobMenu"));
        }
    }
}
