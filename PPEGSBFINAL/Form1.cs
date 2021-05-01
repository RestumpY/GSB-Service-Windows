using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PPEGSBFINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ConnexionSql maConnexion;
        private MySqlCommand oCom;
        private DataTable dt;
        private GestionDate DateClass;


        private void Form1_Load(object sender, EventArgs e)
        {
            maConnexion = ConnexionSql.getInstance("localhost", "gsb", "root", "");
            maConnexion.openConnection();

            affiche();


            GestionDate DC = new GestionDate();


            lbTime.Text = DC.dateDuJour();

            lbMoisPrec.Text = DC.dateMoisPrecedent();
        }

        public void affiche()
        {
            dt = new DataTable();
            GestionDate DC = new GestionDate();

            oCom = maConnexion.reqExec("Select * from fichefrais ");

            MySqlDataReader reader = oCom.ExecuteReader();

            for (int i = 0; i <= reader.FieldCount - 1; i++)
            {
                dt.Columns.Add(reader.GetName(i));
            }

            while (reader.Read())
            {

                DataRow dr = dt.NewRow();

                for (int i = 0; i <= reader.FieldCount - 1; i++)
                {
                    dr[i] = reader.GetValue(i);
                }

                dt.Rows.Add(dr);
            }
            dgv.DataSource = dt;
            reader.Close();
            maConnexion.closeConnection();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            GestionDate DC = new GestionDate();
            /*oCom = maConnexion.reqExec("Select * from fichefrais Where mois=" + DC.dateMoisPrecedent());
            oCom.ExecuteNonQuery();*/


            try
            {


                int dateJour = Convert.ToInt32(DC.getJour());


                if (dateJour >= 1 && dateJour <= 10)
                {
                    maConnexion.openConnection();


                    oCom = maConnexion.reqExec("update fichefrais set idEtat ='CL' where idEtat ='CR' and mois = '" + DC.dateMoisPrecedent() + "'");
                    oCom.ExecuteNonQuery();


                    string dateMoisPrecedent = DC.dateMoisPrecedent();

                    oCom = maConnexion.reqExec("Select * from fichefrais where mois='" + dateMoisPrecedent + "'");
                    DataTable dt = new DataTable();
                    dt.Load(oCom.ExecuteReader());

                    dgv.DataSource = dt;
                    //affiche();
                    maConnexion.closeConnection();
                }
                else if (dateJour >= 20 && dateJour <= 31)
                {
                    maConnexion.openConnection();

                    oCom = maConnexion.reqExec("update fichefrais set idEtat ='RB' where idEtat ='VA' and mois = '" + DC.dateMoisPrecedent() + "'");
                    oCom.ExecuteNonQuery();


                    string dateMoisPrecedent = DC.dateMoisPrecedent();

                    oCom = maConnexion.reqExec("Select * from fichefrais where mois='" + dateMoisPrecedent + "'");
                    DataTable dt = new DataTable();
                    dt.Load(oCom.ExecuteReader());

                    dgv.DataSource = dt;

                    //affiche();

                    maConnexion.closeConnection();
                }

            }
            catch (Exception emp)
            {
                MessageBox.Show(emp.Message);
            }
        }



       

        private void idVisiteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeEtat_Click_1(object sender, EventArgs e)
        {

            
                maConnexion.openConnection();
                GestionDate DC = new GestionDate();

                if (Convert.ToInt32(DC.getJour()) <= 10)
                {
                    oCom = maConnexion.reqExec(" Update fichefrais set idEtat = 'CL' where idVisiteur = '" + idVisiteur.Text + "' and idEtat ='CR'");
                    DataTable dt = new DataTable();
                    dt.Load(oCom.ExecuteReader());
                    affiche();
                }
                else if (Convert.ToInt32(DC.getJour()) <= 31 | Convert.ToInt32(DC.getJour()) >= 20)
                {
                    oCom = maConnexion.reqExec(" Update fichefrais set idEtat = 'VA' where idVisiteur = '" + idVisiteur.Text + "' and idEtat ='RB'");
                    DataTable dt = new DataTable();
                    dt.Load(oCom.ExecuteReader());
                    affiche();
                }



            }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }






}


