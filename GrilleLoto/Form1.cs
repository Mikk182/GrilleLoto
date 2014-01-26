using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using GrilleLoto.DatabaseLayer;

namespace GrilleLoto
{

    public partial class Form1 : Form
    {
        private Service _service { get; set; }
        public ArrayList t_liste;
        public ArrayList lbl_liste;
        public int cpt;
        public int last;

        public Form1()
        {
            _service = new Service();

            InitializeComponent();

            t_liste = new ArrayList();
            lbl_liste = new ArrayList();
            UserForm_Initialize();
        }

        public void BubbleSort()
        {
            Int32 tmp, k, test, loBound, upBound;

            // initialize bounds

            loBound = this.t_liste.ToArray().GetLowerBound(0);
            upBound = this.t_liste.ToArray().GetUpperBound(0);

            k = upBound;

            //test = 0;
            do
            {
                test = 0;
                for (int i = loBound; i <= k - 1; i++)
                {
                    if (Convert.ToInt32(this.t_liste[i]) > Convert.ToInt32(this.t_liste[i + 1]))
                    {
                        test = i;
                        tmp = Convert.ToInt32(this.t_liste[i]);
                        this.t_liste[i] = this.t_liste[i + 1];
                        this.t_liste[i + 1] = tmp;
                    }
                }
                k = test; // increase lower bound, improve performances
            } while (test != 0);
        }

        public Int32 taille()
        {
            try
            {
                Int32 val;
                if (this.t_liste.ToArray().GetLowerBound(0) == 0)
                {
                    val = 1;
                }
                else
                {
                    val = this.t_liste.ToArray().GetUpperBound(0) + 1;
                }
                return val;
            }
            catch
            {
                return 0;
            }
        }

        public void ajouter(Int32 i)
        {
            if (i != null)
            {
                t_liste.Add(i);
                Variables.CurPartie.Numbers.Add(new Number
                    {
                        Num = i
                    });
            }
        }

        public void afficher()
        {
            nbEntries.Text = t_liste.Count.ToString() + "Boules tirées";

            Int32 i = 0;
            foreach (Control dynCont in this.lbl_liste)
            {
                if (t_liste.Count > i)
                {
                    if ((t_liste.Count > 0) && (((dynCont).Name.Substring(1, 1) == t_liste[i].ToString().Substring(0, 1)) || (Convert.ToInt32(t_liste[i]) < 10)))
                    {
                        (dynCont).Text = t_liste[i].ToString();
                        if (Convert.ToInt32(this.t_liste[i]) == last)
                        {
                            (dynCont).BackColor = Color.Red;
                            (dynCont).ForeColor = Color.Black;
                        }
                        else
                        {
                            (dynCont).BackColor = Color.Blue;
                            (dynCont).ForeColor = Color.White;
                        }
                        i++;
                    }
                    else
                    {
                        (dynCont).BackColor = Color.Blue;
                        (dynCont).ForeColor = Color.White;
                        (dynCont).Text = "";
                    }
                }
            }
        }

        public Boolean entier(Int32 nb)
        {
            try
            {
                Int32 test = Convert.ToInt32(nb);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private Boolean exist(Int32 nb)
        {
            bool result = false;
            for (int i = 0; i < t_liste.Count - 1; i++)
            {
                if (t_liste.Count != 0)
                {
                    if (Convert.ToInt32(t_liste[i]) == nb)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public void effacer(bool erasetab)
        {
            foreach (Control dynCont in this.lbl_liste)
            {
                (dynCont).BackColor = Color.Blue;
                (dynCont).Text = "";
            }
            if (erasetab)
            {
                t_liste.Clear();
            }
            TB_Saisie.Text = "";
            TB_Saisie.Focus();
        }

        private void UserForm_Initialize()
        {
            // Set the size of the form slightly less than size of  working rectangle. 
            this.Size = new System.Drawing.Size(
                Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);

            // Set the location so the entire form is visible. 
            this.Location = new System.Drawing.Point(0, 0);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            var width = Screen.PrimaryScreen.Bounds.Size.Width / 10;
            var height = (Screen.PrimaryScreen.Bounds.Size.Height - 66) / 10;
            const int space = 3;

            var titles = new[]
                {
                    "[1-9]", "[10-19]", "[20-29]", "[30-39]", "[40-49]", "[50-59]", "[60-69]", "[70-79]", "[80-89]", "[90]"
                };

            nbEntries.Text = "Aucune entrée";

            for (int c = 0; c <= 9; c++)
            {
                //93*30
                var labelTop = new Label();
                //93-3-93
                labelTop.Left = width * c;
                labelTop.Width = width - space;

                labelTop.Top = 36;
                labelTop.Height = 30;

                labelTop.BackColor = Color.Black;
                labelTop.ForeColor = Color.White;

                labelTop.Font = new Font("Tahoma", height / 4, FontStyle.Bold);
                labelTop.TextAlign = ContentAlignment.MiddleCenter;

                labelTop.Name = "Top" + c.ToString();
                labelTop.Text = titles[c];
                this.Controls.Add(labelTop);

                for (int l = 0; l <= 9; l++)
                {
                    if ((c == 0 && l == 9) || (c == 9 && l != 0))
                        continue;

                    var LabelSim = new Label();

                    LabelSim.Left = width * c;
                    LabelSim.Width = width - space;

                    LabelSim.Top = height * l + 66;
                    LabelSim.Height = height - space;

                    LabelSim.BackColor = Color.Blue;

                    LabelSim.Font = new Font("Tahoma", height / 2);
                    LabelSim.TextAlign = ContentAlignment.MiddleCenter;

                    LabelSim.Name = "L" + c.ToString() + "_" + l.ToString();

                    LabelSim.DoubleClick += new System.EventHandler(this.ctrlClick);

                    this.Controls.Add(LabelSim);
                    lbl_liste.Add(LabelSim);
                }
            }
        }

        private void ctrlClick(System.Object sender, EventArgs e)
        {
            var ctrl = (Control)sender;
            t_liste.RemoveAt(t_liste.IndexOf(Convert.ToInt32(ctrl.Text)));

            afficher();
        }

        private void B_Ajout_Click(object sender, EventArgs e)
        {
            try
            {
                if (entier(Convert.ToInt32(TB_Saisie.Text)))
                {
                    if (!exist(Convert.ToInt32(TB_Saisie.Text)))
                    {
                        if (Convert.ToInt32(TB_Saisie.Text) < 100)
                        {
                            ajouter(Convert.ToInt32(TB_Saisie.Text));
                            last = Convert.ToInt32(TB_Saisie.Text);

                            BubbleSort();

                            afficher();

                            TB_Saisie.Text = "";
                            TB_Saisie.Focus();

                            if (_service.ExistPartie(Variables.CurPartie))
                            {
                                // TODO : Update
                            }
                            else
                            {
                                // TODO : Save
                            }
                        }
                        else
                        {
                            MessageBox.Show(TB_Saisie.Text + " interdit !");
                            TB_Saisie.Text = "";
                            TB_Saisie.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(TB_Saisie.Text + " déjà sorti !");
                        TB_Saisie.Text = "";
                        TB_Saisie.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Entier attendu !");
                    TB_Saisie.Text = "";
                    TB_Saisie.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entier attendu !");
                TB_Saisie.Text = "";
                TB_Saisie.Focus();
            }
        }

        private void B_Efface_Click(object sender, EventArgs e)
        {
            effacer(true);
        }

        private void TB_Saisie_TextChanged(object sender, EventArgs e)
        {
            //B_Ajout.Focus();
        }

        private void TB_Saisie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                B_Ajout.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //bd.Close();
        }

        private void b_gestion_Click(object sender, EventArgs e)
        {
            Form formGest = new Form2();
            formGest.Show();
        }
    }
}
