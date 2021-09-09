namespace CFB_Academia
{
    partial class F_GestaoProfessores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluirProfessor = new System.Windows.Forms.Button();
            this.btn_salvarProfessor = new System.Windows.Forms.Button();
            this.btn_novoProfessor = new System.Windows.Forms.Button();
            this.dgv_professor = new System.Windows.Forms.DataGridView();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.tb_professor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluirProfessor);
            this.panel1.Controls.Add(this.btn_salvarProfessor);
            this.panel1.Controls.Add(this.btn_novoProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 30);
            this.panel1.TabIndex = 12;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(329, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(101, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluirProfessor
            // 
            this.btn_excluirProfessor.Location = new System.Drawing.Point(223, 3);
            this.btn_excluirProfessor.Name = "btn_excluirProfessor";
            this.btn_excluirProfessor.Size = new System.Drawing.Size(100, 23);
            this.btn_excluirProfessor.TabIndex = 2;
            this.btn_excluirProfessor.Text = "Excluir Professor";
            this.btn_excluirProfessor.UseVisualStyleBackColor = true;
            this.btn_excluirProfessor.Click += new System.EventHandler(this.btn_excluirProfessor_Click);
            // 
            // btn_salvarProfessor
            // 
            this.btn_salvarProfessor.Location = new System.Drawing.Point(115, 3);
            this.btn_salvarProfessor.Name = "btn_salvarProfessor";
            this.btn_salvarProfessor.Size = new System.Drawing.Size(102, 23);
            this.btn_salvarProfessor.TabIndex = 1;
            this.btn_salvarProfessor.Text = "Salvar Professor";
            this.btn_salvarProfessor.UseVisualStyleBackColor = true;
            this.btn_salvarProfessor.Click += new System.EventHandler(this.btn_salvarProfessor_Click);
            // 
            // btn_novoProfessor
            // 
            this.btn_novoProfessor.Location = new System.Drawing.Point(10, 3);
            this.btn_novoProfessor.Name = "btn_novoProfessor";
            this.btn_novoProfessor.Size = new System.Drawing.Size(99, 23);
            this.btn_novoProfessor.TabIndex = 0;
            this.btn_novoProfessor.Text = "Novo Professor";
            this.btn_novoProfessor.UseVisualStyleBackColor = true;
            this.btn_novoProfessor.Click += new System.EventHandler(this.btn_novoProfessor_Click);
            // 
            // dgv_professor
            // 
            this.dgv_professor.AllowUserToAddRows = false;
            this.dgv_professor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_professor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professor.EnableHeadersVisualStyles = false;
            this.dgv_professor.Location = new System.Drawing.Point(12, 47);
            this.dgv_professor.MultiSelect = false;
            this.dgv_professor.Name = "dgv_professor";
            this.dgv_professor.ReadOnly = true;
            this.dgv_professor.RowHeadersVisible = false;
            this.dgv_professor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professor.Size = new System.Drawing.Size(415, 363);
            this.dgv_professor.TabIndex = 11;
            this.dgv_professor.SelectionChanged += new System.EventHandler(this.dgv_professor_SelectionChanged);
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(327, 21);
            this.mtb_telefone.Mask = "(99) 9999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtb_telefone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Professor";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 21);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(80, 20);
            this.tb_ID.TabIndex = 8;
            this.tb_ID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(324, 5);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 13;
            this.lbTelefone.Text = "Telefone";
            // 
            // tb_professor
            // 
            this.tb_professor.Location = new System.Drawing.Point(99, 22);
            this.tb_professor.Name = "tb_professor";
            this.tb_professor.Size = new System.Drawing.Size(222, 20);
            this.tb_professor.TabIndex = 1;
            // 
            // F_GestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.tb_professor);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_professor);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GestaoProfessores";
            this.Load += new System.EventHandler(this.F_GestaoProfessores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirProfessor;
        private System.Windows.Forms.Button btn_novoProfessor;
        private System.Windows.Forms.DataGridView dgv_professor;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox tb_professor;
        private System.Windows.Forms.Button btn_salvarProfessor;
    }
}