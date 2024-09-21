using LogisticService.Data;
using System.Runtime.InteropServices;
using LogisticService.AdminInterface;
using LogisticService.UserPanel;

class Program
{
    static void Main(String[] args)
    {
        //UserMenu userMenu = new UserMenu();
        //userMenu.Menu();

        AdminPanel adminPanel = new AdminPanel();
        adminPanel.AdminChoiceTable();
    }
}

