using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeHelpDesk
{
    public partial class Form1 : Form
    {
        bool mostrandoAbertos = false;
        public Form1()
        {
            InitializeComponent();

            // garante foco inicial (opcional manter comentado se quiser)
            // this.BeginInvoke(new Action(() => txtUsuario.Focus()));

            CarregarChamados();
        }
        public class Chamado
        {
            public int Id { get; set; }
            public string Usuario { get; set; }
            public string Descricao { get; set; }
            public string Status { get; set; }
            public DateTime DataCriacao { get; set; }

            public override string ToString()
            {
                return $"[{DataCriacao}] {Status}: {Usuario}: {Descricao}";
            }
        }
        private void CarregarChamados(bool apenasAbertos = false)
        {
            string connStr = "server=localhost;user=root;password=ACE$777;database=helpdesk;";
            using (var conn = new MySqlConnection(connStr)) 
            {
                conn.Open();

                string sql = @"
                SELECT c.Id, u.Nome, c.Descricao, c.Status, c.DataCriacao
                FROM Chamados c
                JOIN Usuarios u ON c.UsuarioId = u.Id
                " + (apenasAbertos ? "WHERE c.Status = 'ABERTO'" : "") + @"
                ORDER BY c.DataCriacao DESC";

                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                lstChamados.Items.Clear();

                while (reader.Read())
                {
                    Chamado c = new Chamado
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Usuario = reader["Nome"].ToString(),
                        Descricao = reader["Descricao"].ToString(),
                        Status = reader["Status"].ToString(),
                        DataCriacao = Convert.ToDateTime(reader["DataCriacao"])
                    };

                    lstChamados.Items.Add(c); // 🔥 objeto, não string
                }
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Preencha usuário e descrição.");
                return;
            }

            string connStr = "server=localhost;user=root;password=ACE$777;database=helpdesk;";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // 🔹 Primeiro pega ou cria usuário
                string getUser = "SELECT Id FROM Usuarios WHERE Nome = @nome";
                var cmdUser = new MySqlCommand(getUser, conn);
                cmdUser.Parameters.AddWithValue("@nome", txtUsuario.Text);

                object result = cmdUser.ExecuteScalar();
                int usuarioId;

                if (result == null)
                {
                    string insertUser = "INSERT INTO Usuarios (Nome) VALUES (@nome); SELECT LAST_INSERT_ID();";
                    var cmdInsert = new MySqlCommand(insertUser, conn);
                    cmdInsert.Parameters.AddWithValue("@nome", txtUsuario.Text);

                    usuarioId = Convert.ToInt32(cmdInsert.ExecuteScalar());
                }
                else
                {
                    usuarioId = Convert.ToInt32(result);
                }

                // 🔹 Inserir chamado
                string insertChamado = @"INSERT INTO Chamados 
            (UsuarioId, Descricao, Status, DataCriacao)
            VALUES (@u, @d, 'ABERTO', NOW())";

                var cmdChamado = new MySqlCommand(insertChamado, conn);
                cmdChamado.Parameters.AddWithValue("@u", usuarioId);
                cmdChamado.Parameters.AddWithValue("@d", txtDescricao.Text);

                cmdChamado.ExecuteNonQuery();
            }

            txtDescricao.Clear();
            txtUsuario.Clear();

            CarregarChamados();
        }
        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (lstChamados.SelectedItem == null)
            {
                MessageBox.Show("Selecione um chamado.");
                return;
            }

            // Aqui você precisa do ID (vamos melhorar isso depois)
            string connStr = "server=localhost;user=root;password=ACE$777;database=helpdesk;";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "UPDATE Chamados SET Status = 'RESOLVIDO', DataFechamento = NOW() WHERE Id = @id";

                var cmd = new MySqlCommand(sql, conn);
                Chamado selecionado = (Chamado)lstChamados.SelectedItem;
                cmd.Parameters.AddWithValue("@id", selecionado.Id);

                cmd.ExecuteNonQuery();
            }

            CarregarChamados();
        }
        private void btnMostrarAbertos_Click(object sender, EventArgs e)
        {
            mostrandoAbertos = !mostrandoAbertos;

            CarregarChamados(mostrandoAbertos);

            if (mostrandoAbertos)
                btnMostrarAbertos.Text = "Mostrar Todos";
            else
                btnMostrarAbertos.Text = "Mostrar Abertos";
        }

        private void lstChamados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
