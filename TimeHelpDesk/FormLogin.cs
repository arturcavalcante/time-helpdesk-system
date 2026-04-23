using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeHelpDesk
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // aqui depois você valida no banco

            string connStr = "server=localhost;user=root;password=ACE$777;database=helpdesk;";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT Id, Nome 
                   FROM Usuarios 
                   WHERE Login = @login AND Senha = @senha";

                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UsuarioLogado.Id = Convert.ToInt32(reader["Id"]);
                    UsuarioLogado.Nome = reader["Nome"].ToString();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos.");
                }
            }
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.ShowDialog();
        }
    }
}
