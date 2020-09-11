using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afro_Wearing
{
    public partial class Cadastro : Form
    {
        

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSair_Click(object sender, EventArgs e)
        {
            //Confirmação do botão sair + caixa de dialogo
            DialogResult sair = MessageBox.Show("Fechar Aplicação?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //Confirmação de sair
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BCadastrar_Click(object sender, EventArgs e)
        {

           
           //Verificador do campo nome +  perfil da msg de erro. 
            if (CNomeC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Nome. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo sobrenome +  perfil da msg de erro. 
            if (CSobrenomeC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Sobrenome. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo E-Mail +  perfil da msg de erro. 
            if (CEmailC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo E-mail. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo Senha +  perfil da msg de erro. 
            if (CSenhaC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Senha. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }

            //Verificador do campo Confirmar Senha +  perfil da msg de erro. 
            if (CCSenhaC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo confirmação de Senha. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo CPF +  perfil da msg de erro. 
            if (CCPFC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo CPF. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo Data de nascimento +  perfil da msg de erro. 
            if (CDataNasC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Data de Nascimento. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Verificador do campo Telefone Residencial +  perfil da msg de erro. 
            if (CTelResiC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Telefone Residencial. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo Telefone Celular +  perfil da msg de erro. 
            if (CTelCelC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Telefone Celular. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo Sexo +  perfil da msg de erro. 
            if (CTelCelC.Text == "")
            {
                MessageBox.Show(" Campo Sexo não foi selecionado. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //Verificador do campo Endereço +  perfil da msg de erro. 
            if (CEndereçoC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Endereço. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo Numero do Endereço +  perfil da msg de erro. 
            if (CnumeroC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo Nª da Residencia. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verificador do campo CEP +  perfil da msg de erro. 
            if (CcepC.Text == "")
            {
                MessageBox.Show(" Favor verificar o campo CEP. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show(" Cadastro salvo com sucesso! Favor ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Abrilitando o botão "Cadastro" 
                BCadastrar.Enabled = true;

                //Voltando pra tela HOMe 
                PHome _f2;
                _f2 = new PHome();
                _f2.Show();
                Hide();
                
            }



            Cadastro_Salvo_.CnomeS = CNomeC.Text;
            Cadastro_Salvo_.CSobrenomeS = CEmailC.Text;


            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CNomeC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bvoltar_Click(object sender, EventArgs e)
        {
            PHome _f2;
            _f2 = new PHome();
            _f2.Show();
            Hide();
        }

        private void BSair_Click_1(object sender, EventArgs e)
        {
            //Confirmação do botão sair + caixa de dialogo
            DialogResult sair = MessageBox.Show("Fechar Aplicação?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //Confirmação de sair
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
