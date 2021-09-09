using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    //PROCEDIMENTOS
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso nao permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0" ;
            lb_nomeUsuario.Text = "...";
            pb_ledLogado.Image = Properties.Resources.vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //PROCEDIMENTOS
                }
                else
                {
                    MessageBox.Show("Acesso nao permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    //PROCEDIMENTOS
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso nao permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    //PROCEDIMENTOS
                    F_GestaoUsuario f_GestaoUsuario = new F_GestaoUsuario();
                    f_GestaoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso nao permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            abreForm(1, f_NovoAluno);
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abreForm(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abreForm(2, f_GestaoProfessores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            abreForm(2, f_GestaoTurmas);
        }

        private void gestaoAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
            abreForm(2, f_GestaoAlunos);
        }
    }
}
