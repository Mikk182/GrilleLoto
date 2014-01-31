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
    public partial class Form3 : Form
    {
        private Service _service { get; set; }
        

        public Form3()
        {
            InitializeComponent();
            
            _service = new Service();

            var journeeList = _service.GetJournees();

            foreach (var journee in journeeList)
            {
                JourneeListBox.Items.Add(journee.Num);
            }
        }

        private void NewJournee_Click(object sender, EventArgs e)
        {
            var journee = new Journee
            {
                Num = this.textBox1.Text,
                Date = DateTime.Now
            };

            if (!_service.ExistJournee(journee))
            {
                Variables.CurJournee = _service.InsertJournee(journee);
            }
            else
            {
                Variables.CurJournee = _service.GetJournee(journee);
            }
            JourneeListBox.Items.Add(journee.Num);
            Form2 frm = new Form2();
            frm.Show();
        }

        private void LoadJournee_Click(object sender, EventArgs e)
        {
            var journee = new Journee
            {
                Num = (string)JourneeListBox.SelectedValue,
                Date = DateTime.Now
            };

            Variables.CurJournee = _service.GetJournee(journee);
            Form2 frm = new Form2();
            frm.Show();
        }

    }
}
