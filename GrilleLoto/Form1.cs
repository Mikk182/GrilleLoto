using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace GrilleLoto
{

    public partial class Form1 : Form
    {
        //public Int32[] t_liste ;
        public ArrayList t_liste;
        public ArrayList lbl_liste;
        public int cpt;
        public int last;
        BDD bd;
        //public with Label L_Dyn;

        public Form1()
        {
            InitializeComponent();

            //t_liste = new Int32[99];
            t_liste = new ArrayList();
            lbl_liste = new ArrayList();
            UserForm_Initialize();
            //bd = new BDD("./GrilleLoto_BDD.accdb");

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

            //On Error GoTo err:
            try
            {
                //Dim val As Integer
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
                //If UBound(t_liste()) = 0 Then
                //    val = 1
                //Else
                //    val = UBound(t_liste()) + 1
                //End If
                //taille = val
                //Exit Function
            }
            catch
            {
                return 0;
                //taille = 0;
            }
        }

        //err:
        //    taille = 0

        //End Function

        public void ajouter(Int32 i)
        {

            if (i != null)
            {
                //if (this.taille() == 0)
                //{
                //    ReDim Preserve t_liste[0];
                //}else{
                //    ReDim Preserve t_liste[t_liste.GetUpperBound(0) + 1];
                //}


                t_liste.Add(i);
                //t_liste[t_liste.Count] = i;
            }

        }


        public void afficher()
        {
            Int32 i = 0;
            foreach (Control dynCont in this.lbl_liste)
            {
                if (t_liste.Count >= i)
                {
                    //if ((dynCont.GetType() == label1.GetType()) &&(dynCont.Name != "label1"))
                    //{
                    if ((t_liste.Count > 0) && ((((Label)dynCont).Name.Substring(1, 1) == t_liste[i].ToString().Substring(0, 1)) || (Convert.ToInt32(t_liste[i]) < 10)))
                    {
                        ((Label)dynCont).Text = t_liste[i].ToString();
                        if (Convert.ToInt32(this.t_liste[i]) == last)
                        {
                            ((Label)dynCont).BackColor = Color.Red;
                            ((Label)dynCont).ForeColor = Color.Black;
                        }
                        else
                        {
                            ((Label)dynCont).BackColor = Color.Blue;
                            ((Label)dynCont).ForeColor = Color.White;
                        }
                        i++;
                    }
                    else
                    {
                        ((Label)dynCont).BackColor = Color.Blue;
                        ((Label)dynCont).ForeColor = Color.White;
                        ((Label)dynCont).Text = "";
                    }
                    //}
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
                //if ((dynCont.GetType() == label1.GetType()) && (dynCont.Name != "label1"))
                //{
                ((Label)dynCont).BackColor = Color.Blue;
                ((Label)dynCont).Text = "";
                //}
            }
            if (erasetab)
            {
                t_liste.Clear();
                //for (int i = 0; i <= t_liste.Count; i++)
                //{
                //    t_liste[i] = 0;
                //}
            }
            TB_Saisie.Text = "";
            TB_Saisie.Focus();
        }
        private void UserForm_Initialize()
        {
            // Set the size of the form slightly less than size of  
            // working rectangle. 
            this.Size = new System.Drawing.Size(
                Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);

            // Set the location so the entire form is visible. 
            this.Location = new System.Drawing.Point(0, 0);
            for (int c = 0; c <= 9; c++)
            {
                for (int l = 0; l <= 9; l++)
                {
                    Label LabelSim = new Label();

                    LabelSim.Left = 96 * c;
                    LabelSim.Width = 93;

                    //LabelSim.Top = 42*l +66;
                    //LabelSim.Height = 39;
                    LabelSim.Top = 50 * l + 66;
                    LabelSim.Height = 47;

                    LabelSim.BackColor = Color.Blue;

                    LabelSim.Font = new Font("Tahoma", 30);
                    LabelSim.TextAlign = ContentAlignment.MiddleCenter;

                    LabelSim.Name = "L" + c.ToString() + "_" + l.ToString();
                    //LabelSim.Text = c.ToString() + l.ToString();

                    LabelSim.DoubleClick += new System.EventHandler(this.ctrlClick);

                    this.Controls.Add(LabelSim);
                    lbl_liste.Add(LabelSim);
                }
            }
        }

        //    private void UserForm_Initialize()
        //    {
        //        Int32 longueur;
        //        Int32 hauteur;
        //        Label L_Dyn;

        //Dim Cl As ClasBT
        //Set Collect = New Collection


        //    For l = 1 To 10
        //        For c = 0 To 9
        //foreach
        //    ((CheckBox)c).CheckedChanged += new System.EventHandler(this.ClickMe);
        //L_Dyn = Controls.Add("forms.label.1", "L" & c & "_" & l, True)


        //            Set Cl = New ClasBT 'Ajouter à la collection de classe
        //            Set Cl.GroupBoutons = L_Dyn
        //            Call Cl.set_c(c)
        //            Call Cl.set_l(l)
        //            Collect.Add Cl


        //            With L_Dyn
        //                .Top = 66 + hauteur
        //                .Left = 0 + longueur
        //                .Width = 93
        //                .Height = 39
        //                .FontSize = 30
        //                .FontName = "Tahoma"
        //                .TextAlign = fmTextAlignCenter
        //                .BackColor = &H8000000F

        //            End With
        //            'pn_map.Controls.Add (L_Dyn)
        //            'addhandler L_Dyn.Click, AdresseOf DblClick_Labels
        //            'L_Dyn.c = DblClick_Labels(c, l)
        //            longueur = longueur + 96
        //            'ajouter (l * 10 + c)
        //        Next
        //        longueur = 0
        //        hauteur = hauteur + 42
        //    Next
        //    afficher
        //End Sub
        private void ctrlClick(System.Object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            //MessageBox.Show("You clicked: " + ctrl.Name + " "+ ctrl.Text);
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
            catch
            {
                MessageBox.Show("Entier attendu !");
                TB_Saisie.Text = "";
                TB_Saisie.Focus();
            }
        }
        //Private Sub B_Ajout_Click()

        //    If entier(TB_Saisie.Text) Then

        //        If Not exist(CInt(TB_Saisie.Text)) Then
        //            If CInt(TB_Saisie.Text) < 100 Then
        //                ajouter (CInt(TB_Saisie.Text))
        //                last = CInt(TB_Saisie.Text)

        //                BubbleSort

        //                afficher
        //            Else
        //                MsgBox TB_Saisie.Text & " interdit"
        //            End If
        //        Else
        //            MsgBox TB_Saisie.Text & " déjà sorti"
        //        End If

        //    Else
        //        MsgBox "entier attendu !"
        //    End If

        //    TB_Saisie = ""
        //    TB_Saisie.SetFocus
        //End Sub

        private void B_Efface_Click(object sender, EventArgs e)
        {
            effacer(true);
        }
        ////Private Sub CB_TEff_Click()
        ////    effacer (True)
        ////End Sub

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

        //Public Sub DblClick_Labels(ByVal c As Integer, ByVal l As Integer)

        //    If Controls.Item("L" & c & "_" & l) <> "" Then
        //        For i = 0 To UBound(t_liste())
        //            If t_liste(i) = Controls.Item("L" & c & "_" & l) Then
        //                If i = 0 And taille = 1 Then
        //                    effacer (True)
        //                Else
        //                    For X = i + 1 To UBound(t_liste)
        //                        t_liste(X - 1) = t_liste(X)
        //                    Next
        //                    ReDim Preserve t_liste(UBound(t_liste) - 1)
        //                    effacer (False)
        //                End If

        //                afficher
        //                Exit For
        //            End If
        //        Next
        //    End If

        //End Sub


    }
}
