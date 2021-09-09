namespace CFB_Academia
{
    partial class F_GestaoUsuario
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fecharJanela = new System.Windows.Forms.Button();
            this.btn_excluirUsuario = new System.Windows.Forms.Button();
            this.btn_salvarAlteracoes = new System.Windows.Forms.Button();
            this.btn_novoUsuario = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "D = Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "B = Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "A = Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nível";
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(163, 178);
            this.n_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(147, 20);
            this.n_nivel.TabIndex = 21;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(12, 178);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(145, 21);
            this.cb_status.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(163, 130);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(147, 20);
            this.tb_senha.TabIndex = 17;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 130);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(145, 20);
            this.tb_username.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 86);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(298, 20);
            this.tb_nome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fecharJanela);
            this.panel1.Controls.Add(this.btn_excluirUsuario);
            this.panel1.Controls.Add(this.btn_salvarAlteracoes);
            this.panel1.Controls.Add(this.btn_novoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 31);
            this.panel1.TabIndex = 26;
            // 
            // btn_fecharJanela
            // 
            this.btn_fecharJanela.Location = new System.Drawing.Point(502, 3);
            this.btn_fecharJanela.Name = "btn_fecharJanela";
            this.btn_fecharJanela.Size = new System.Drawing.Size(160, 23);
            this.btn_fecharJanela.TabIndex = 3;
            this.btn_fecharJanela.Text = "Fechar Janela";
            this.btn_fecharJanela.UseVisualStyleBackColor = true;
            // 
            // btn_excluirUsuario
            // 
            this.btn_excluirUsuario.Location = new System.Drawing.Point(336, 3);
            this.btn_excluirUsuario.Name = "btn_excluirUsuario";
            this.btn_excluirUsuario.Size = new System.Drawing.Size(160, 23);
            this.btn_excluirUsuario.TabIndex = 2;
            this.btn_excluirUsuario.Text = "Excluir Usuario";
            this.btn_excluirUsuario.UseVisualStyleBackColor = true;
            this.btn_excluirUsuario.Click += new System.EventHandler(this.btn_excluirUsuario_Click);
            // 
            // btn_salvarAlteracoes
            // 
            this.btn_salvarAlteracoes.Location = new System.Drawing.Point(170, 3);
            this.btn_salvarAlteracoes.Name = "btn_salvarAlteracoes";
            this.btn_salvarAlteracoes.Size = new System.Drawing.Size(160, 23);
            this.btn_salvarAlteracoes.TabIndex = 1;
            this.btn_salvarAlteracoes.Text = "Salvar Alteracoes";
            this.btn_salvarAlteracoes.UseVisualStyleBackColor = true;
            this.btn_salvarAlteracoes.Click += new System.EventHandler(this.btn_salvarAlteracoes_Click);
            // 
            // btn_novoUsuario
            // 
            this.btn_novoUsuario.Location = new System.Drawing.Point(4, 3);
            this.btn_novoUsuario.Name = "btn_novoUsuario";
            this.btn_novoUsuario.Size = new System.Drawing.Size(160, 23);
            this.btn_novoUsuario.TabIndex = 0;
            this.btn_novoUsuario.Text = "Novo Usuario";
            this.btn_novoUsuario.UseVisualStyleBackColor = true;
            this.btn_novoUsuario.Click += new System.EventHandler(this.btn_novoUsuario_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 38);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(100, 20);
            this.tb_ID.TabIndex = 28;
            this.tb_ID.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // dgv_usuarios
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.EnableHeadersVisualStyles = false;
            this.dgv_usuarios.Location = new System.Drawing.Point(316, 12);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(346, 240);
            this.dgv_usuarios.TabIndex = 29;
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            // 
            // F_GestaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 296);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "F_GestaoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao de Usuario";
            this.Load += new System.EventHandler(this.F_GestaoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown n_nivel;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fecharJanela;
        private System.Windows.Forms.Button btn_excluirUsuario;
        private System.Windows.Forms.Button btn_salvarAlteracoes;
        private System.Windows.Forms.Button btn_novoUsuario;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_usuarios;
    }
}