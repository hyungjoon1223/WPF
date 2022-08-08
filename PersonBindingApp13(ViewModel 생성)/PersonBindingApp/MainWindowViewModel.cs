using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBindingApp
{
    class MainWindowViewModel
    {
        private PersonList perList = new PersonList(); // 디폴트 뷰 1개
        public PersonList PerList => perList;

        private AddPersonCommand addPerCommand;
        public AddPersonCommand AddPerCommand
        {
            get { return addPerCommand; }
            set { addPerCommand = value; }
        }
    }

}
