namespace CFB_Academia
{
    partial class F_NovoAluno
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
            this.btn_novo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_statusAluno = new System.Windows.Forms.ComboBox();
            this.mtb_telefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.tb_nomeAluno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.btn_selTurma = new System.Windows.Forms.Button();
            this.btn_selPlano = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_addFoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(3, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(102, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // cb_statusAluno
            // 
            this.cb_statusAluno.Enabled = false;
            this.cb_statusAluno.FormattingEnabled = true;
            this.cb_statusAluno.Location = new System.Drawing.Point(12, 80);
            this.cb_statusAluno.Name = "cb_statusAluno";
            this.cb_statusAluno.Size = new System.Drawing.Size(154, 21);
            this.cb_statusAluno.TabIndex = 2;
            // 
            // mtb_telefoneAluno
            // 
            this.mtb_telefoneAluno.Enabled = false;
            this.mtb_telefoneAluno.Location = new System.Drawing.Point(331, 25);
            this.mtb_telefoneAluno.Mask = "(99) 99999-9999";
            this.mtb_telefoneAluno.Name = "mtb_telefoneAluno";
            this.mtb_telefoneAluno.Size = new System.Drawing.Size(100, 20);
            this.mtb_telefoneAluno.TabIndex = 3;
            // 
            // tb_nomeAluno
            // 
            this.tb_nomeAluno.Enabled = false;
            this.tb_nomeAluno.Location = new System.Drawing.Point(12, 25);
            this.tb_nomeAluno.Name = "tb_nomeAluno";
            this.tb_nomeAluno.Size = new System.Drawing.Size(313, 20);
            this.tb_nomeAluno.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 30);
            this.panel1.TabIndex = 5;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(327, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(102, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(219, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(111, 3);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(102, 23);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Turma";
            // 
            // tb_plano
            // 
            this.tb_plano.Location = new System.Drawing.Point(12, 139);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.ReadOnly = true;
            this.tb_plano.Size = new System.Drawing.Size(248, 20);
            this.tb_plano.TabIndex = 10;
            this.tb_plano.TabStop = false;
            // 
            // tb_turma
            // 
            this.tb_turma.Location = new System.Drawing.Point(172, 81);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(232, 20);
            this.tb_turma.TabIndex = 11;
            this.tb_turma.TabStop = false;
            this.tb_turma.Tag = "1";
            // 
            // btn_selTurma
            // 
            this.btn_selTurma.Location = new System.Drawing.Point(404, 79);
            this.btn_selTurma.Name = "btn_selTurma";
            this.btn_selTurma.Size = new System.Drawing.Size(27, 23);
            this.btn_selTurma.TabIndex = 4;
            this.btn_selTurma.Text = "...";
            this.btn_selTurma.UseVisualStyleBackColor = true;
            this.btn_selTurma.Click += new System.EventHandler(this.btn_selTurma_Click);
            // 
            // btn_selPlano
            // 
            this.btn_selPlano.Location = new System.Drawing.Point(257, 137);
            this.btn_selPlano.Name = "btn_selPlano";
            this.btn_selPlano.Size = new System.Drawing.Size(27, 23);
            this.btn_selPlano.TabIndex = 12;
            this.btn_selPlano.Text = "...";
            this.btn_selPlano.UseVisualStyleBackColor = true;
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(437, 12);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(85, 113);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 13;
            this.pb_foto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*jpg)|*jpg|PNG(*png)|*png";
            // 
            // btn_addFoto
            // 
            this.btn_addFoto.Location = new System.Drawing.Point(437, 131);
            this.btn_addFoto.Name = "btn_addFoto";
            this.btn_addFoto.Size = new System.Drawing.Size(85, 23);
            this.btn_addFoto.TabIndex = 14;
            this.btn_addFoto.Text = "Add Foto";
            this.btn_addFoto.UseVisualStyleBackColor = true;
            this.btn_addFoto.Click += new System.EventHandler(this.btn_addFoto_Click);
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 241);
            this.Controls.Add(this.btn_addFoto);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.btn_selPlano);
            this.Controls.Add(this.btn_selTurma);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_nomeAluno);
            this.Controls.Add(this.mtb_telefoneAluno);
            this.Controls.Add(this.cb_statusAluno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_NovoAluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_statusAluno;
        private System.Windows.Forms.MaskedTextBox mtb_telefoneAluno;
        private System.Windows.Forms.TextBox tb_nomeAluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.Button btn_selTurma;
        private System.Windows.Forms.Button btn_selPlano;
        public System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_addFoto;
    }
}