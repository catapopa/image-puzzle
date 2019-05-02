using System;
using System.Drawing;
using System.Windows.Forms;


namespace puzzle{
    static class Program{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			//Controller controller = new Controller();
			FirstWindow firstWindow = new FirstWindow();
			Application.Run(firstWindow);
        }
    }
}
