using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOPWalkThrough1
{
    class EntryPoint
    {
        public static void Main()
        {
            PersonInformationUI personInformationUIObj = new PersonInformationUI();
            Application.Run(personInformationUIObj);
        }
    }
}
