namespace ProjetoX
{
    partial class Iniciar
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_idad = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_sob = new System.Windows.Forms.TextBox();
            this.txb_idad = new System.Windows.Forms.TextBox();
            this.btn_adiciona = new System.Windows.Forms.Button();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.ptb_imagemcoreeto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_boas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagemcoreeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(409, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(293, 29);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Bem Vindo ao Projeto X";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(344, 136);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(160, 24);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Digite seu Nome :";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sobrenome.Location = new System.Drawing.Point(344, 189);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(208, 24);
            this.lbl_sobrenome.TabIndex = 3;
            this.lbl_sobrenome.Text = "Digite seu Sobrenome :";
            // 
            // lbl_idad
            // 
            this.lbl_idad.AutoSize = true;
            this.lbl_idad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idad.Location = new System.Drawing.Point(344, 235);
            this.lbl_idad.Name = "lbl_idad";
            this.lbl_idad.Size = new System.Drawing.Size(154, 24);
            this.lbl_idad.TabIndex = 4;
            this.lbl_idad.Text = "Digite sua Idade :";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(592, 141);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(101, 20);
            this.txb_nome.TabIndex = 5;
            // 
            // txb_sob
            // 
            this.txb_sob.Location = new System.Drawing.Point(592, 193);
            this.txb_sob.Name = "txb_sob";
            this.txb_sob.Size = new System.Drawing.Size(101, 20);
            this.txb_sob.TabIndex = 6;
            // 
            // txb_idad
            // 
            this.txb_idad.Location = new System.Drawing.Point(592, 239);
            this.txb_idad.Name = "txb_idad";
            this.txb_idad.Size = new System.Drawing.Size(101, 20);
            this.txb_idad.TabIndex = 7;
            // 
            // btn_adiciona
            // 
            this.btn_adiciona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_adiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adiciona.Location = new System.Drawing.Point(33, 363);
            this.btn_adiciona.Name = "btn_adiciona";
            this.btn_adiciona.Size = new System.Drawing.Size(146, 46);
            this.btn_adiciona.TabIndex = 8;
            this.btn_adiciona.Text = "ADICIONAR";
            this.btn_adiciona.UseVisualStyleBackColor = false;
            this.btn_adiciona.Click += new System.EventHandler(this.btn_adiciona_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_limpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpa.Location = new System.Drawing.Point(319, 362);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(126, 47);
            this.btn_limpa.TabIndex = 9;
            this.btn_limpa.Text = "LIMPAR";
            this.btn_limpa.UseVisualStyleBackColor = false;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(607, 363);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(109, 46);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(922, 179);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 11;
            // 
            // ptb_imagemcoreeto
            // 
            this.ptb_imagemcoreeto.Location = new System.Drawing.Point(925, 251);
            this.ptb_imagemcoreeto.Name = "ptb_imagemcoreeto";
            this.ptb_imagemcoreeto.Size = new System.Drawing.Size(270, 170);
            this.ptb_imagemcoreeto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_imagemcoreeto.TabIndex = 12;
            this.ptb_imagemcoreeto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoX.Properties.Resources.sebastiaan_stam_RChZT_JlI9g_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_boas
            // 
            this.lbl_boas.AutoSize = true;
            this.lbl_boas.Location = new System.Drawing.Point(916, 106);
            this.lbl_boas.Name = "lbl_boas";
            this.lbl_boas.Size = new System.Drawing.Size(0, 13);
            this.lbl_boas.TabIndex = 13;
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 520);
            this.Controls.Add(this.lbl_boas);
            this.Controls.Add(this.ptb_imagemcoreeto);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.btn_adiciona);
            this.Controls.Add(this.txb_idad);
            this.Controls.Add(this.txb_sob);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.lbl_idad);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Iniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagemcoreeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_idad;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_sob;
        private System.Windows.Forms.TextBox txb_idad;
        private System.Windows.Forms.Button btn_adiciona;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.PictureBox ptb_imagemcoreeto;
        private System.Windows.Forms.Label lbl_boas;
    }
}