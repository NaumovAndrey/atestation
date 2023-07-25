
using App.Controller;
using App.Controller.Interfaces;
using App.Data.Interfaces;
using App.Data.WithOutSql;
using App.Infrastructure;
using App.Infrastructure.Interfaces;
using App.View;
using App.View.Interfaces;

namespace App
{
    public class Program
    {
        public static void Main()
        {
            IDbRequest db = new DbRequest();
            IInfrastructure infrastructure = new InfrastructureBasic();
            IView view = new ViewForConsole();
            IController controller = new ControllerBasic(db, infrastructure, view);
            controller.RunMainMenu();
        }
    }
}