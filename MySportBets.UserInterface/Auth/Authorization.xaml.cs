using MySportBets.Server.UserService;
using MySportBets.Ui.Services;
using MySportBets.UserInterface.Factory;
using MySportBets.UserInterface.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace MySportBets.Userinterface.Auth
{
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();  

            btn.Click += (s, e) =>
            {
                MainMenu.MainMenu mainMenu = _viewFactory.Build<MainMenu.MainMenu>();
                mainMenu.ShowDialog();
            }; 
        }
    }
}
