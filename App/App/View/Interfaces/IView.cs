using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.View.Interfaces
{
    internal interface IView
    {
        public void ShowMainMenu();
        public void ShowAnimalMenu();
        public void ShowAddMenu();
        public void ShowCommandsMenu();
        public void ShowAddCommandMenu();
        public void ShowRemoveMenu();
        public void ShowCheckMenu();
        public void ShowAnimalTypeMenu();
        public void ShowText(string text);
        public void ShowError();
        public void ShowRequestData();
        public void ShowPreviewText();
        public void ShowNotFoundt();
        public void ShowSuccessMessage();
        public void ShowExitMenu();

    }
}