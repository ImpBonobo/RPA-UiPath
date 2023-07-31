using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgramm
{
     public class Launcher {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            View view = new View();
            Model model = new Model();
            Controller controller = new Controller(view, model);
            Application.Run(view);

            WordParser wp = new WordParser();
            wp.main();
        }
    }
}
