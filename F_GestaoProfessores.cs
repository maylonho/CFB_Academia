using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            string vquery = @"
            SELECT
                N_IDPROFESSOR as 'ID Professor',
                T_NOMEPROFESSOR as 'Professor',
                T_TELEFONE as 'Telefone'
            FROM
                tb_professores
            ORDER BY
                T_NOMEPROFESSOR
            ";
            dgv_professor.DataSource = Banco.dql(vquery);
            dgv_professor.Columns[0].Width = 40;
            dgv_professor.Columns[1].Width = 250;
            dgv_professor.Columns[2].Width = 100;
        }

        private void btn_salvarProfessor_Click(object sender, EventArgs e)
        {
            string vquery;
            if (tb_ID.Text == "")
            {
                vquery = "INSERT INTO tb_professores(T_NOMEPROFESSOR, T_TELEFONE) VALUES ('" + tb_professor.Text + "', '"+mtb_telefone.Text+"')";
            }
            else
            {
                vquery = "UPDATE tb_professores SET T_NOMEPROFESSOR='" + tb_professor.Text + "', T_TELEFONE='" + mtb_telefone.Text + "' WHERE N_IDPROFESSOR=" + tb_ID.Text;
            }
            Banco.dml(vquery);
            vquery = @"
                SELECT
                N_IDPROFESSOR as 'ID Professor',
                T_NOMEPROFESSOR as 'Professor',
                T_TELEFONE as 'Telefone'
            FROM
                tb_professores
            ORDER BY
                T_NOMEPROFESSOR
            ";
            dgv_professor.DataSource = Banco.dql(vquery);

        }

        private void dgv_professor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT
                        *
                    FROM
                        tb_professores
                    WHERE
                        N_IDPROFESSOR=" + vid;
                dt = Banco.dql(vquery);
                tb_ID.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_professor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                ;
            }
        }

        private void btn_novoProfessor_Click(object sender, EventArgs e)
        {
            tb_ID.Clear();
            tb_professor.Clear();
            mtb_telefone.Clear();
            tb_professor.Focus();
        }

        private void btn_excluirProfessor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + tb_ID.Text;
                Banco.dml(vquery);
                dgv_professor.Rows.Remove(dgv_professor.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
