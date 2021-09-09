namespace CFB_Academia
{
    partial class F_Horarios
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
            this.btn_novoHorario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_horario = new System.Windows.Forms.MaskedTextBox();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluirHorario = new System.Windows.Forms.Button();
            this.btn_salvarHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_novoHorario
            // 
            this.btn_novoHorario.Location = new System.Drawing.Point(12, 3);
            this.btn_novoHorario.Name = "btn_novoHorario";
            this.btn_novoHorario.Size = new System.Drawing.Size(88, 23);
            this.btn_novoHorario.TabIndex = 0;
            this.btn_novoHorario.Text = "Novo Horário";
            this.btn_novoHorario.UseVisualStyleBackColor = true;
            this.btn_novoHorario.Click += new System.EventHandler(this.btn_novoHorario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 25);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(80, 20);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horário";
            // 
            // mtb_horario
            // 
            this.mtb_horario.Location = new System.Drawing.Point(98, 25);
            this.mtb_horario.Mask = "99:99 \\até 99:99";
            this.mtb_horario.Name = "mtb_horario";
            this.mtb_horario.Size = new System.Drawing.Size(100, 20);
            this.mtb_horario.TabIndex = 4;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(12, 51);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(377, 363);
            this.dgv_horarios.TabIndex = 5;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluirHorario);
            this.panel1.Controls.Add(this.btn_salvarHorario);
            this.panel1.Controls.Add(this.btn_novoHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 30);
            this.panel1.TabIndex = 6;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(299, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(90, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluirHorario
            // 
            this.btn_excluirHorario.Location = new System.Drawing.Point(204, 3);
            this.btn_excluirHorario.Name = "btn_excluirHorario";
            this.btn_excluirHorario.Size = new System.Drawing.Size(89, 23);
            this.btn_excluirHorario.TabIndex = 2;
            this.btn_excluirHorario.Text = "Excluir Horário";
            this.btn_excluirHorario.UseVisualStyleBackColor = true;
            this.btn_excluirHorario.Click += new System.EventHandler(this.btn_excluirHorario_Click);
            // 
            // btn_salvarHorario
            // 
            this.btn_salvarHorario.Location = new System.Drawing.Point(107, 3);
            this.btn_salvarHorario.Name = "btn_salvarHorario";
            this.btn_salvarHorario.Size = new System.Drawing.Size(91, 23);
            this.btn_salvarHorario.TabIndex = 1;
            this.btn_salvarHorario.Text = "Salvar Horário";
            this.btn_salvarHorario.UseVisualStyleBackColor = true;
            this.btn_salvarHorario.Click += new System.EventHandler(this.btn_salvarHorario_Click);
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.mtb_horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novoHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_horario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirHorario;
        private System.Windows.Forms.Button btn_salvarHorario;
    }
}