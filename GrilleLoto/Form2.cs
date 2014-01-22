using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrilleLoto.DatabaseLayer;

namespace GrilleLoto
{
    public partial class Form2 : Form
    {
        private Service _service { get; set; }
        

        public Form2()
        {
            _service = new Service();

            InitializeComponent();

            var journee = new Journee();
            journee.Num = "";
            journee.Date = DateTime.Now;
            //journee.Partie.Add();

            //var partie = new Partie();
            //partie.Numbers.Add():

            

            

        }

        private void b_new_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
