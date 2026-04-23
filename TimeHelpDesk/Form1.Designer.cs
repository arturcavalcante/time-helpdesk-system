namespace TimeHelpDesk
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lstChamados = new System.Windows.Forms.ListBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnMostrarAbertos = new System.Windows.Forms.Button();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição do chamado";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(22, 66);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(163, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(22, 92);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(83, 23);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir chamado";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lstChamados
            // 
            this.lstChamados.FormattingEnabled = true;
            this.lstChamados.Location = new System.Drawing.Point(207, 25);
            this.lstChamados.Name = "lstChamados";
            this.lstChamados.Size = new System.Drawing.Size(486, 108);
            this.lstChamados.TabIndex = 5;
            this.lstChamados.SelectedIndexChanged += new System.EventHandler(this.lstChamados_SelectedIndexChanged);
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(207, 139);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 6;
            this.btnResolver.Text = "Resolver chamado";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // btnMostrarAbertos
            // 
            this.btnMostrarAbertos.Location = new System.Drawing.Point(591, 139);
            this.btnMostrarAbertos.Name = "btnMostrarAbertos";
            this.btnMostrarAbertos.Size = new System.Drawing.Size(102, 23);
            this.btnMostrarAbertos.TabIndex = 7;
            this.btnMostrarAbertos.Text = "Mostrar abertos";
            this.btnMostrarAbertos.UseVisualStyleBackColor = true;
            this.btnMostrarAbertos.Click += new System.EventHandler(this.btnMostrarAbertos_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(19, 25);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(35, 13);
            this.lblUsuarioLogado.TabIndex = 8;
            this.lblUsuarioLogado.Text = "label1";
            this.lblUsuarioLogado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.btnMostrarAbertos);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.lstChamados);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ListBox lstChamados;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnMostrarAbertos;
        private System.Windows.Forms.Label lblUsuarioLogado;
    }
}

