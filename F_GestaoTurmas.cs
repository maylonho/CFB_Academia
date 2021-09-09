using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace CFB_Academia
{
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0; //0-Padrão, 1-Edicao, 2-Inserção
        string vqueryDGV;

        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"SELECT 
                                N_IDTURMA as 'ID',
                                T_DSCTURMA as 'Turma',
                                T_DSCHORARIO as 'Horario'
                              FROM
                                tb_turmas as tbt
                              INNER JOIN
                                tb_horarios as tbh on tbh.N_IDHORARIO =tbt.N_IDHORARIO
";


            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 200;
            dgv_turmas.Columns[2].Width = 100;

            //popular Combo box professores
            string vqueryProfessores = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR
                ";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            //popular combo box Status (Ativa = A, Paralisada = P, Cancelada = C)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "key";

            //popular combo Box Horarios
            string vqueryHorarios = @"
                SELECT
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
                ";
            cb_horarios.Items.Clear();
            cb_horarios.DataSource = Banco.dql(vqueryHorarios);
            cb_horarios.DisplayMember = "T_DSCHORARIO";
            cb_horarios.ValueMember = "N_IDHORARIO";
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                modo = 0;
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA="+idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                tb_nomeTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");


                
                tb_vagas.Text = calcVagas();
            }
        }

        private string calcVagas()
        {
            //Calculo de vagas
            string queryVagas = String.Format(@"
                    SELECT
                        count(N_IDALUNO) as 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS='A' and N_IDTURMA={0}", idSelecionado);
            DataTable dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_nomeTurma.Clear();
            cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horarios.SelectedIndex = -1;
            tb_nomeTurma.Focus();
            modo = 2;
            
        }

        private void btn_salvarTurma_Click(object sender, EventArgs e)
        {
            if (modo != 0) {
                string queryTurma = "";
                string msg = "";
                if (modo==1){
                    msg = "Dados Alterados";
                    queryTurma = String.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                        T_DSCTURMA='{0}',
                        N_IDPROFESSOR={1},
                        N_IDHORARIO={2},
                        N_MAXALUNOS={3},
                        T_STATUS='{4}'
                    WHERE
                        N_IDTURMA={5}", tb_nomeTurma.Text, cb_professor.SelectedValue, cb_horarios.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);

                }else
                {
                    msg = "Nova turma inserida";
                    queryTurma = String.Format(@"
                        INSERT INTO tb_turmas
                        (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS)
                        VALUES('{0}', {1}, {2}, {3}, '{4}')", tb_nomeTurma.Text, cb_professor.SelectedValue, cb_horarios.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue);  
                 }
                int linha = dgv_turmas.SelectedRows[0].Index;

                Banco.dml(queryTurma);
                if (modo == 1)
                {
                    dgv_turmas[1, linha].Value = tb_nomeTurma.Text;
                    dgv_turmas[2, linha].Value = cb_horarios.Text;
                    tb_vagas.Text = calcVagas();  
                }
                else
                {
                    dgv_turmas.DataSource = Banco.dql(vqueryDGV);
                }
                
                MessageBox.Show(msg);
            }
        }

        private void btn_excluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão", "Excluir?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                    DELETE
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA={0}", idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void tb_nomeTurma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
            
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void n_maxAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void btn_imprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho+ @"\logocfb.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;
            //logo.SetAbsolutePosition(100f, 750f); //X, -Y

            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatorio de Turmas\n\n");
            

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("CFB Cursos - Curso de C#");

            PdfPTable tabela = new PdfPTable(3); //3Colunas
            tabela.DefaultCell.FixedHeight = 20;
            //tabela.DefaultCell.BorderWidth = 10;

            //PdfPCell celula = new PdfPCell(new Phrase("tabela de Precos"));
            //celula.Colspan = 3;//Linha 1 mesclada
            //celula.Rotation = 90;
            //tabela.AddCell(celula);

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horario");

            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for(int i = 0;i< dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horario").ToString());
            }

            /*
            PdfPCell celula2 = new PdfPCell(new Phrase("Tabela de Precos"));
            celula2.Colspan = 3;//Linha 1 Mesclada
            celula2.FixedHeight = 35;
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela.AddCell(celula2);
            */


            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relatorio?", "Relatorio", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            
            }
        }
    }
}
