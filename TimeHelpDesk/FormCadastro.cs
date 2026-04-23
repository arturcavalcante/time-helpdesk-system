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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            // 🔹 validações
            if (nome.Length < 3 || login.Length < 3 || senha.Length < 3)
            {
                MessageBox.Show("Nome, login e senha devem ter pelo menos 3 caracteres.");
                return;
            }

            string connStr = "server=localhost;user=root;password=ACE$777;database=helpdesk;";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // 🔹 verificar se login já existe
                string checkSql = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login";
                var checkCmd = new MySqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@login", login);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Esse login já existe.");
                    return;
                }

                // 🔹 inserir usuário
                string insertSql = @"INSERT INTO Usuarios (Nome, Login, Senha)
                         VALUES (@n, @l, @s)";

                var cmd = new MySqlCommand(insertSql, conn);
                cmd.Parameters.AddWithValue("@n", nome);
                cmd.Parameters.AddWithValue("@l", login);
                cmd.Parameters.AddWithValue("@s", senha);

                cmd.ExecuteNonQuery();
            }

            // 🔹 feedback
            MessageBox.Show("Usuário criado com sucesso!");

            // 🔹 limpar campos
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }
    }
}
