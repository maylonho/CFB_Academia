namespace CFB_Academia
{
    partial class F_GestaoTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_imprimirTurma = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluirTurma = new System.Windows.Forms.Button();
            this.btn_salvarTurma = new System.Windows.Forms.Button();
            this.btn_novaTurma = new System.Windows.Forms.Button();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.n_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_horarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomeTurma = new System.Windows.Forms.TextBox();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_imprimirTurma);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluirTurma);
            this.panel1.Controls.Add(this.btn_salvarTurma);
            this.panel1.Controls.Add(this.btn_novaTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 30);
            this.panel1.TabIndex = 20;
            // 
            // btn_imprimirTurma
            // 
            this.btn_imprimirTurma.Location = new System.Drawing.Point(329, 3);
            this.btn_imprimirTurma.Name = "btn_imprimirTurma";
            this.btn_imprimirTurma.Size = new System.Drawing.Size(100, 23);
            this.btn_imprimirTurma.TabIndex = 4;
            this.btn_imprimirTurma.Text = "Imprimir Turma";
            this.btn_imprimirTurma.UseVisualStyleBackColor = true;
            this.btn_imprimirTurma.Click += new System.EventHandler(this.btn_imprimirTurma_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(437, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(101, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluirTurma
            // 
            this.btn_excluirTurma.Location = new System.Drawing.Point(223, 3);
            this.btn_excluirTurma.Name = "btn_excluirTurma";
            this.btn_excluirTurma.Size = new System.Drawing.Size(100, 23);
            this.btn_excluirTurma.TabIndex = 2;
            this.btn_excluirTurma.Text = "Excluir Turma";
            this.btn_excluirTurma.UseVisualStyleBackColor = true;
            this.btn_excluirTurma.Click += new System.EventHandler(this.btn_excluirTurma_Click);
            // 
            // btn_salvarTurma
            // 
            this.btn_salvarTurma.Location = new System.Drawing.Point(115, 3);
            this.btn_salvarTurma.Name = "btn_salvarTurma";
            this.btn_salvarTurma.Size = new System.Drawing.Size(102, 23);
            this.btn_salvarTurma.TabIndex = 1;
            this.btn_salvarTurma.Text = "Salvar Turma";
            this.btn_salvarTurma.UseVisualStyleBackColor = true;
            this.btn_salvarTurma.Click += new System.EventHandler(this.btn_salvarTurma_Click);
            // 
            // btn_novaTurma
            // 
            this.btn_novaTurma.Location = new System.Drawing.Point(10, 3);
            this.btn_novaTurma.Name = "btn_novaTurma";
            this.btn_novaTurma.Size = new System.Drawing.Size(99, 23);
            this.btn_novaTurma.TabIndex = 0;
            this.btn_novaTurma.Text = "Nova Turma";
            this.btn_novaTurma.UseVisualStyleBackColor = true;
            this.btn_novaTurma.Click += new System.EventHandler(this.btn_novaTurma_Click);
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(365, 396);
            this.dgv_turmas.TabIndex = 19;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Professor";
            // 
            // n_maxAlunos
            // 
            this.n_maxAlunos.Location = new System.Drawing.Point(393, 121);
            this.n_maxAlunos.Name = "n_maxAlunos";
            this.n_maxAlunos.Size = new System.Drawing.Size(174, 20);
            this.n_maxAlunos.TabIndex = 3;
            this.n_maxAlunos.ValueChanged += new System.EventHandler(this.n_maxAlunos_ValueChanged);
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(393, 74);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(328, 21);
            this.cb_professor.TabIndex = 2;
            this.cb_professor.SelectedIndexChanged += new System.EventHandler(this.cb_professor_SelectedIndexChanged);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(573, 120);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(148, 21);
            this.cb_status.TabIndex = 4;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // cb_horarios
            // 
            this.cb_horarios.FormattingEnabled = true;
            this.cb_horarios.Location = new System.Drawing.Point(393, 169);
            this.cb_horarios.Name = "cb_horarios";
            this.cb_horarios.Size = new System.Drawing.Size(328, 21);
            this.cb_horarios.TabIndex = 5;
            this.cb_horarios.SelectedIndexChanged += new System.EventHandler(this.cb_horarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Maximo Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Horário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nome da Turma";
            // 
            // tb_nomeTurma
            // 
            this.tb_nomeTurma.Location = new System.Drawing.Point(393, 29);
            this.tb_nomeTurma.Name = "tb_nomeTurma";
            this.tb_nomeTurma.Size = new System.Drawing.Size(328, 20);
            this.tb_nomeTurma.TabIndex = 1;
            this.tb_nomeTurma.TextChanged += new System.EventHandler(this.tb_nomeTurma_TextChanged);
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Location = new System.Drawing.Point(393, 234);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(108, 20);
            this.tb_vagas.TabIndex = 29;
            this.tb_vagas.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vagas";
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.tb_nomeTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_horarios);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.n_maxAlunos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_turmas);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GestaoTurmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirTurma;
        private System.Windows.Forms.Button btn_salvarTurma;
        private System.Windows.Forms.Button btn_novaTurma;
        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_imprimirTurma;
        private System.Windows.Forms.NumericUpDown n_maxAlunos;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_horarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nomeTurma;
        private System.Windows.Forms.TextBox tb_vagas;
        private System.Windows.Forms.Label label6;
    }
}