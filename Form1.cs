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
    public partial class Form1 : Form
    {
        form2 s = new form2();
        public Form1()
        {
            InitializeComponent();
         

        }
        public void tomar()
        {
            using (StreamWriter txto = new StreamWriter(@"D:\texto.txt"))
            {
                txto.WriteLine(txtoriginal.Text);


            }

            File.WriteAllText(@"D:\texto.txt", txtoriginal.Text);

        }


        public void poner()
        {

            s.txtcopia.Text = txtoriginal.Text;


        }

        private void btninicio_Click(object sender, System.EventArgs e)
        {
           
            
            Thread a = new Thread(tomar);
            a.Start();
            a.Join();


            Thread b = new Thread(poner);
            b.Start();
            b.Join();


            s.Show();


        }
    }
}
