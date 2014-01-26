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
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            var curPartie = new Partie();
            curPartie.Num = 1;
            curPartie.Date = DateTime.Now;

            curPartie.Journee = Variables.CurJournee;

            Variables.CurPartie = curPartie;
            //Variables.CurJournee.Parties.Add(curPartie);

            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
