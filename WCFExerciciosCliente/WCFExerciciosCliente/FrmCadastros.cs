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
    public partial class FrmCadastros : Form
    {
        private ServiceExercicios.ServiceClient client = new ServiceExercicios.ServiceClient();
      private  ServiceExercicios.Exercicio exercicio;
        public FrmCadastros(ServiceExercicios.Exercicio exercicio)
        {
            InitializeComponent();
            if(exercicio.idExercicio > -1)
            {
                txtNome.Text = exercicio.nome;
                txtObs.Text = exercicio.observacao;
                txtRepeticoes.Text = exercicio.repeticoes;
                cmbTipo.Text = exercicio.tipo;
                this.exercicio = exercicio;
            }
            else
            {
                this.exercicio = new ServiceExercicios.Exercicio();
                this.exercicio.idExercicio = -1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja Gravar os Dados", "Gravar",MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
            {
                exercicio.nome = txtNome.Text;
                exercicio.tipo = cmbTipo.Text;
                exercicio.repeticoes = txtRepeticoes.Text;
                exercicio.observacao = txtObs.Text;

                if (exercicio.idExercicio > -1)//Update
                {


                    client.UpdateExercicios(exercicio);
                    MessageBox.Show("Dados Atualizados");
                }
                else //Insert
                {

                    client.InsertExercicios(exercicio);

                    MessageBox.Show("Dados Inseridos");
                }
                this.Close();
               

            }//Fim da resposta Yes Button
            else
            {
                MessageBox.Show("Exercicio não incluido");
            }
        }
    }
}
