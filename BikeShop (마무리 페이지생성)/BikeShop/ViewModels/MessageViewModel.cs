using BikeShop.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BikeShop.ViewModels
{
    internal class MessageViewModel
    {
        public MessageCommand DisplayMessageCommand { get; set; }

        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }
        public void DisplayMessage()
        {
            MessageBox.Show("클릭했쌈");

        }
    }
}