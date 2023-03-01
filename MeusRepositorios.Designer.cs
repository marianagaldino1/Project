namespace Dev_Project
{
    partial class MeusRepositorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLinguagem = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvarFavorito = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDono
            // 
            this.txtDono.Location = new System.Drawing.Point(163, 136);
            this.txtDono.Name = "txtDono";
            this.txtDono.Size = new System.Drawing.Size(189, 23);
            this.txtDono.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Linguagem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dono do repositório:";
            // 
            // txtLinguagem
            // 
            this.txtLinguagem.Location = new System.Drawing.Point(163, 88);
            this.txtLinguagem.Name = "txtLinguagem";
            this.txtLinguagem.Size = new System.Drawing.Size(189, 23);
            this.txtLinguagem.TabIndex = 12;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(163, 52);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(189, 23);
            this.txtDescricao.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 23);
            this.txtNome.TabIndex = 14;
            // 
            // btnSalvarFavorito
            // 
            this.btnSalvarFavorito.Location = new System.Drawing.Point(29, 235);
            this.btnSalvarFavorito.Name = "btnSalvarFavorito";
            this.btnSalvarFavorito.Size = new System.Drawing.Size(118, 40);
            this.btnSalvarFavorito.TabIndex = 15;
            this.btnSalvarFavorito.Text = "Adicionar ao favoritos";
            this.btnSalvarFavorito.UseVisualStyleBackColor = true;
            this.btnSalvarFavorito.Click += new System.EventHandler(this.btnSalvarFavorito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data da última atualização:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(184, 173);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(189, 23);
            this.txtData.TabIndex = 17;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(184, 235);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(118, 40);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(327, 235);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(118, 40);
            this.btnDeletar.TabIndex = 19;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(465, 235);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 40);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // MeusRepositorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvarFavorito);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtLinguagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDono);
            this.Name = "MeusRepositorios";
            this.Text = "MeusRepositorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDono;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label5;
        private TextBox txtLinguagem;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private Button btnSalvarFavorito;
        private Label label3;
        private TextBox txtData;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Button btnVoltar;
    }
}