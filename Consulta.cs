//Eduardo Cavalcante - 19/11/2022

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApInfo_Eduardo
{
    public partial class Consulta : Form
    {

        Candidato cand = new Candidato();
        

        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database = apinfo; password = ''");
            MySqlCommand query = new MySqlCommand("SELECT * FROM candidato", conexao);
            try
            {
                conexao.Open();
                MySqlDataReader datReader = query.ExecuteReader();
                while (datReader.Read())
                {
                    object[] registro = new object[datReader.FieldCount];
                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < datReader.FieldCount; i++)
                            dataGridView1.Columns.Add(datReader.GetName(i), datReader.GetName(i));
                        //Monta a Coluna
                    }
                    for (int i = 0; i < datReader.FieldCount; i++)
                    {
                        registro[i] = datReader.GetValue(i);
                    }
                    dataGridView1.Rows.Add(registro); //Monta a linha
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }




            private void btnVoltar_Click(object sender, EventArgs e)
            {
                this.Hide();
            }
        } }

