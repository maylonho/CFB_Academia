namespace CFB_Academia
{
    partial class F_GestaoAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_fincanceiro = new System.Windows.Forms.Button();
            this.btn_ecluirAluno = new System.Windows.Forms.Button();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.pb_fotoAluno = new System.Windows.Forms.PictureBox();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.btn_imprimirCarteir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_fincanceiro);
            this.panel1.Controls.Add(this.btn_ecluirAluno);
            this.panel1.Controls.Add(this.btn_salvarEdicoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 30);
            this.panel1.TabIndex = 0;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(441, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(140, 23);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_fincanceiro
            // 
            this.btn_fincanceiro.Location = new System.Drawing.Point(295, 3);
            this.btn_fincanceiro.Name = "btn_fincanceiro";
            this.btn_fincanceiro.Size = new System.Drawing.Size(140, 23);
            this.btn_fincanceiro.TabIndex = 8;
            this.btn_fincanceiro.Text = "Financeiro";
            this.btn_fincanceiro.UseVisualStyleBackColor = true;
            this.btn_fincanceiro.Click += new System.EventHandler(this.btn_fincanceiro_Click);
            // 
            // btn_ecluirAluno
            // 
            this.btn_ecluirAluno.Location = new System.Drawing.Point(149, 3);
            this.btn_ecluirAluno.Name = "btn_ecluirAluno";
            this.btn_ecluirAluno.Size = new System.Drawing.Size(140, 23);
            this.btn_ecluirAluno.TabIndex = 7;
            this.btn_ecluirAluno.Text = "Excluir Aluno";
            this.btn_ecluirAluno.UseVisualStyleBackColor = true;
            this.btn_ecluirAluno.Click += new System.EventHandler(this.btn_ecluirAluno_Click);
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(3, 3);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(140, 23);
            this.btn_salvarEdicoes.TabIndex = 6;
            this.btn_salvarEdicoes.Text = "Salvar Edicoes";
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvarEdicoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(314, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(267, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(314, 136);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(267, 21);
            this.cb_turmas.TabIndex = 3;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(314, 82);
            this.mtb_telefone.Mask = "(99) 0000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(121, 20);
            this.mtb_telefone.TabIndex = 4;
            // 
            // pb_fotoAluno
            // 
            this.pb_fotoAluno.Location = new System.Drawing.Point(314, 212);
            this.pb_fotoAluno.Name = "pb_fotoAluno";
            this.pb_fotoAluno.Size = new System.Drawing.Size(79, 108);
            this.pb_fotoAluno.TabIndex = 5;
            this.pb_fotoAluno.TabStop = false;
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.EnableHeadersVisualStyles = false;
            this.dgv_alunos.Location = new System.Drawing.Point(12, 12);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_alunos.RowHeadersVisible = false;
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.Size = new System.Drawing.Size(296, 402);
            this.dgv_alunos.TabIndex = 7;
            this.dgv_alunos.SelectionChanged += new System.EventHandler(this.dgv_alunos_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Turmas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(441, 82);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(140, 21);
            this.cb_status.TabIndex = 13;
            // 
            // btn_imprimirCarteir
            // 
            this.btn_imprimirCarteir.Location = new System.Drawing.Point(314, 183);
            this.btn_imprimirCarteir.Name = "btn_imprimirCarteir";
            this.btn_imprimirCarteir.Size = new System.Drawing.Size(267, 23);
            this.btn_imprimirCarteir.TabIndex = 10;
            this.btn_imprimirCarteir.Text = "Imprimir Carteirinha";
            this.btn_imprimirCarteir.UseVisualStyleBackColor = true;
            this.btn_imprimirCarteir.Click += new System.EventHandler(this.btn_imprimirCarteir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Clique duplo para alterar a foto";
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_imprimirCarteir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_alunos);
            this.Controls.Add(this.pb_fotoAluno);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GestaoAlunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.PictureBox pb_fotoAluno;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_fincanceiro;
        private System.Windows.Forms.Button btn_ecluirAluno;
        private System.Windows.Forms.Button btn_salvarEdicoes;
        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_imprimirCarteir;
        private System.Windows.Forms.Label label2;
    }
}