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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lstChamados = new System.Windows.Forms.ListBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnMostrarAbertos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(32, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(155, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição do chamado";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(32, 80);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(155, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(32, 106);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarAbertos);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.lstChamados);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ListBox lstChamados;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnMostrarAbertos;
    }
}

