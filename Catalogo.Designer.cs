using System.Windows.Forms;

namespace Dev_Project
{
    partial class Catalogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDono = new System.Windows.Forms.TextBox();
            this.txtLinguagem = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dtgProjeto = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnListarFavoritos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Linguagem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dono do repositório:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(231, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 23);
            this.txtNome.TabIndex = 5;
            // 
            // txtDono
            // 
            this.txtDono.Location = new System.Drawing.Point(231, 143);
            this.txtDono.Name = "txtDono";
            this.txtDono.Size = new System.Drawing.Size(189, 23);
            this.txtDono.TabIndex = 6;
            // 
            // txtLinguagem
            // 
            this.txtLinguagem.Location = new System.Drawing.Point(231, 85);
            this.txtLinguagem.Name = "txtLinguagem";
            this.txtLinguagem.Size = new System.Drawing.Size(189, 23);
            this.txtLinguagem.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(231, 45);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(189, 23);
            this.txtDescricao.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(586, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 36);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Inserir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(586, 173);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(118, 36);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dtgProjeto
            // 
            this.dtgProjeto.AllowUserToResizeColumns = false;
            this.dtgProjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgProjeto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtgProjeto.Location = new System.Drawing.Point(27, 272);
            this.dtgProjeto.Name = "dtgProjeto";
            this.dtgProjeto.RowTemplate.Height = 25;
            this.dtgProjeto.Size = new System.Drawing.Size(712, 149);
            this.dtgProjeto.TabIndex = 14;
            this.dtgProjeto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProjeto_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(586, 93);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(118, 36);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(586, 48);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 36);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnListarFavoritos
            // 
            this.btnListarFavoritos.Location = new System.Drawing.Point(586, 135);
            this.btnListarFavoritos.Name = "btnListarFavoritos";
            this.btnListarFavoritos.Size = new System.Drawing.Size(118, 36);
            this.btnListarFavoritos.TabIndex = 17;
            this.btnListarFavoritos.Text = "Listar Favoritos";
            this.btnListarFavoritos.UseVisualStyleBackColor = true;
            this.btnListarFavoritos.Click += new System.EventHandler(this.btnListarFavoritos_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarFavoritos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dtgProjeto);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtLinguagem);
            this.Controls.Add(this.txtDono);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Catalogo";
            this.Text = "Catagolo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtDono;
        private TextBox txtLinguagem;
        private TextBox txtDescricao;
        private Button btnSalvar;
        private Button btnDeletar;
        private DataGridView dtgProjeto;
        private Button btnListar;
        private Button btnPesquisar;
        private Button btnListarFavoritos;
    }
}