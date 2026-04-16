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
    public partial class Form1 : Form
    {
        List<string> chamados = new List<string>();

        bool mostrandoAbertos = false;
        public Form1()
        {
            InitializeComponent();

            // garante foco inicial (opcional manter comentado se quiser)
            // this.BeginInvoke(new Action(() => txtUsuario.Focus()));

            CarregarChamados();
        }
        private void CarregarChamados()
        {
            if (System.IO.File.Exists("chamados.txt"))
            {
                chamados = System.IO.File.ReadAllLines("chamados.txt")
                    .Where(c => !string.IsNullOrWhiteSpace(c))
                    .ToList();

                foreach (var chamado in chamados)
                {
                    lstChamados.Items.Add(chamado);
                }
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Preencha usuário e descrição.");
                return;
            }

            string usuario = txtUsuario.Text;
            string descricao = txtDescricao.Text;

            string chamadoFormatado =
                "[ABERTO] [" + DateTime.Now.ToString("dd/MM HH:mm") + "] " +
                usuario + " - " + descricao;

            chamados.Add(chamadoFormatado);
            lstChamados.Items.Add(chamadoFormatado);

            SalvarChamados();

            txtDescricao.Clear();
            txtUsuario.Clear();
        }
        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (lstChamados.SelectedItem == null)
            {
                MessageBox.Show("Selecione um chamado.");
                return;
            }

            string chamadoSelecionado = lstChamados.SelectedItem.ToString();

            string chamadoAtualizado;

            if (chamadoSelecionado.Contains("[ABERTO]"))
            {
                chamadoAtualizado = chamadoSelecionado.Replace("[ABERTO]", "[RESOLVIDO]");
            }
            else if (!chamadoSelecionado.Contains("[RESOLVIDO]"))
            {
                chamadoAtualizado = "[RESOLVIDO] " + chamadoSelecionado;
            }
            else
            {
                MessageBox.Show("Chamado já está resolvido.");
                return;
            }

            int index = lstChamados.SelectedIndex;

            lstChamados.Items[index] = chamadoAtualizado;
            chamados[index] = chamadoAtualizado;

            SalvarChamados();
        }
        void SalvarChamados()
        {
            System.IO.File.WriteAllLines("chamados.txt", chamados);
        }

        private void btnMostrarAbertos_Click(object sender, EventArgs e)
        {
            mostrandoAbertos = !mostrandoAbertos;
            lstChamados.Items.Clear();
            if (mostrandoAbertos)
            {
                foreach (var chamado in chamados)
                {
                    if (chamado.Contains("[ABERTO]"))
                    {
                        lstChamados.Items.Add(chamado);
                    }
                }
                btnMostrarAbertos.Text = "Mostrar Todos";
            }
            else
            {
                foreach (var chamado in chamados) 
                {
                    lstChamados.Items.Add(chamado);
                }
                btnMostrarAbertos.Text = "Mostrar Abertos";
            }
        }
    }
}
