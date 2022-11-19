//Eduardo Cavalcante - 19/11/2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ApInfo_Eduardo
{
    public partial class Cadastro : Form
    {
        Candidato cand = new Candidato();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //Salvar

            cand.setNome(txtNome.Text);
            cand.setSexo(boxSexo.Text);
            cand.setNascimento(dateNascimento.Value);
            cand.setEstado(boxEstado.Text);
            cand.setCidade(txtCidade.Text);
            cand.setCep(txtCep.Text);
            cand.setBairro(txtBairro.Text);
            cand.setTelefone(txtTelefone.Text);
            cand.setEmail(txtEmail.Text);
            cand.setCpf(txtCpf.Text);
            cand.setSenha(txtSenha.Text);
            cand.setFrase(txtFrase.Text);
            cand.setCurriculo(rtbCurriculo.Text);

            MySqlConnection conexao = new MySqlConnection("datasource='localhost';username='root'; password=''; database='apinfo'");
            MySqlCommand command = new MySqlCommand("INSERT INTO candidato (nome, sexo, nascimento, estado, cidade, cep, bairro, telefone, email, cpf, senha, frasesecreta, curriculo)" +
            "VALUES ('" + cand.getNome() + "','" + cand.getSexo() + "','" + cand.getNascimento().ToString("yyyy-MM-dd") + "','" + cand.getEstado() + "','" + cand.getCidade() + "','" + cand.getCep() + "','" + cand.getBairro() + "','" + cand.getTelefone() + "', '" + cand.getEmail() + "','" + cand.getCpf() + "','" + cand.getSenha() + "','" + cand.getFrase() + "','" + cand.getCurriculo() + "')", conexao);
            try
            {
                //Abre conexão com banco
                conexao.Open();
                //Executa
                command.ExecuteReader();
                MessageBox.Show("Currículo cadastrado com Sucesso!", "Cadastro Currículo:", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor encaminhar para setor responsável. Código do erro: " + ex.Message);
            }
            finally
            {
                //Fecha conxão
                conexao.Close();
                
                
            }
        }
    }
    }

