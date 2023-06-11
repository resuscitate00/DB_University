using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Uni
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///
        public static LoginForm FirstForm;
        

        [STAThread]

        static void Main()


        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FirstForm = new LoginForm();
            Application.Run(FirstForm);

        }

    }
    
    }

