using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Resources;
using System;

namespace Texto
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            //using (StreamWriter txto = new StreamWriter(@"D:\texto.txt"))
           // {
             //   txto.WriteLine(this.txto.Text);


         //   }

           // File.WriteAllText(@"D:\texto.txt", txto.Text);
          ////  Application.Exit();
        }

    

        private void txtcopia_TextChanged(object sender, EventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
