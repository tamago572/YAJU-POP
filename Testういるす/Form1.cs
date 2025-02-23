using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testういるす
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new
                 FormClosingEventHandler(CloseWindow);


        }

        private async void CloseWindow(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Form1 newForm = new Form1();
            newForm.Show();

            for (int i = 0; i < 200; i++)
            {
                Random random = new Random(Environment.TickCount);
                await Task.Delay(10);
                Form1 newForm2 = new Form1();
                newForm2.Show();
                newForm2.Location = new Point(random.Next(0, 3000), random.Next(1200));
            }
        }

    }
}
