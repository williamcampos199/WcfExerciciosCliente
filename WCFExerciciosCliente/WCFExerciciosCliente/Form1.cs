using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFExerciciosCliente
{
    public partial class Form1 : Form
    {
        private ServiceExercicios.ServiceClient cliente;
        private ServiceExercicios.Exercicio exercicio;
        private List<ServiceExercicios.Exercicio> exercicios;
        private int idExercicio;



        public Form1()
        {
            InitializeComponent();
            idExercicio = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cliente = new ServiceExercicios.ServiceClient();
            exercicios = new List<ServiceExercicios.Exercicio>( cliente.SelectExercicios() );
            dgvExercicios.DataSource = exercicios;
            exercicio = new ServiceExercicios.Exercicio();


        }

        private void dgvExercicios_DoubleClick(object sender, EventArgs e)
        {
            int linha = dgvExercicios.CurrentRow.Index;
            if (linha > -1)
            {
                Console.WriteLine(linha);
                exercicio = exercicios[linha];
                btnCadastrar.Enabled = false;
                idExercicio = exercicio.idExercicio;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(idExercicio > -1)
            {
                FrmCadastros cadastros = new FrmCadastros(exercicio);
                cadastros.ShowDialog();
                exercicios = new List<ServiceExercicios.Exercicio>(cliente.SelectExercicios());
                dgvExercicios.DataSource = exercicios;
            }
            else
            {
                MessageBox.Show("Selecione um Campo para Edição");
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idExercicio > -1)
            {
                DialogResult resp;
                resp = MessageBox.Show("Deseja Remover os Dados?", "REMOVER", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                if (resp == DialogResult.OK)
                    cliente.DeleteExercicios(exercicio.idExercicio);
                else MessageBox.Show("Exercicio não Removido");
                exercicios = new List<ServiceExercicios.Exercicio>( cliente.SelectExercicios() );
                dgvExercicios.DataSource = exercicios;
                btnCadastrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um Campo para Exclusão");
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            exercicio.idExercicio = -1;
            FrmCadastros cadastros = new FrmCadastros(exercicio);
            cadastros.ShowDialog();

            exercicios = new List<ServiceExercicios.Exercicio>( cliente.SelectExercicios());
            dgvExercicios.DataSource = exercicios;
        }
    }
}

