using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgramm
{

    public class Controller
    {
        private View view;
        private Model model;

        public Controller(View view, Model model)
        {
            this.view = view;
            this.model = model;
            InitializeController();
        }

        public void InitializeController()
        {
            view.BtnCalculate.Click += new EventHandler(this.HelloWorld);
        }

        public void HelloWorld(object sender, EventArgs e)
        {
            int a = int.Parse(view.TxtNumber1.Text);
            int b = int.Parse(view.TxtNumber2.Text);
            model.Calculate(a, b);
            view.LblResult.Text = model.Calculation.ToString();
        }
    }
}
