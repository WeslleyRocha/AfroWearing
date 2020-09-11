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
    public partial class PHome : Form
    {
        public PHome()
        {
            InitializeComponent();
        }



        //Declaração de Vetores Publico
        public string[] vtproduto = new string[11];
        public string[] vtcod = new string[11];
        public double[] vtvalor = new double[11];
        public int[] vtestoque = new int[11];
        //uint indice;


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LogoAfroWearing_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Produtos_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //Produtos
            vtproduto[1] = "Bermuda     ";
            vtproduto[2] = "Camiseta    ";
            vtproduto[3] = "Calça       ";
            vtproduto[4] = "Camisa      ";
            vtproduto[5] = "Jaqueta     ";
            vtproduto[6] = "Agasalho    ";
            vtproduto[7] = "Vestido     ";
            vtproduto[8] = "Saia        ";
            vtproduto[9] = "Boné        ";
            vtproduto[10] = "Meia        ";


            //Valor Produto
            vtvalor[1] = 50.00;
            vtvalor[2] = 95.00;
            vtvalor[3] = 70.00;
            vtvalor[4] = 20.00;
            vtvalor[5] = 80.00;
            vtvalor[6] = 90.00;
            vtvalor[7] = 50.00;
            vtvalor[8] = 75.00;
            vtvalor[9] = 90.00;
            vtvalor[10] = 30.00;


            //Quantidade estoque constante
            vtestoque[1] = 15;
            vtestoque[2] = 11;
            vtestoque[3] = 12;
            vtestoque[4] = 13;
            vtestoque[5] = 15;
            vtestoque[6] = 11;
            vtestoque[7] = 14;
            vtestoque[8] = 19;
            vtestoque[9] = 16;
            vtestoque[10] = 20;



            //Cod do produto vetor
            vtcod[1] = "01   ";
            vtcod[2] = "02   ";
            vtcod[3] = "03   ";
            vtcod[4] = "04   ";
            vtcod[5] = "05   ";
            vtcod[6] = "06   ";
            vtcod[7] = "07   ";
            vtcod[8] = "08   ";
            vtcod[9] = "09   ";
            vtcod[10] = "10   ";


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

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CNome_Click(object sender, EventArgs e)
        {
            string vnome;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Alerta de msg 
            // DialogResult textBox1_TextChanged = MessageBox.Show("Digite seu E-mail");

            //aviso melhor, com caixa de dialogo, e informaçõe adicionais


        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (CEmail.Text == "" || CSenha.Text == "")

            {

                MessageBox.Show(" Favor revisar os campos E-Mail / Senha !", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Login efetuado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BTNAddCarrinho.Enabled = true;

            }



        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BComprar_Click(object sender, EventArgs e)
        {

        }

        private void CSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BCadastrar_Click(object sender, EventArgs e)
        {

            Cadastro _f2;
            _f2 = new Cadastro();
            _f2.Show();
            Hide();

        }
        private void AbrirNovaJanelaCadastro(object obj)
        {
            Application.Run(new Cadastro());

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)

            {
                CValor.Text = "R$ 99,99";
                Ctotal.Text = "R$ 99,99";
                CResumoo.Text = " O que mais chama atenção nesse moletom é a qualidade de seu tecido. Ela tem esse lindo padrão de textura quadriculada que faz toda a diferença na hora de montar seu visual. ";
                ImgProdutos.Image = Properties.Resources.Agasalho;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                CValor.Text = "R$ 10,99";
                Ctotal.Text = "R$ 10,99";
                CResumoo.Text = " Bermuda Fitness Moletom ";
                ImgProdutos.Image = Properties.Resources.Bermuda;

            }
        }

        private void ImgProdutos_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                CValor.Text = "R$ 80,99";
                Ctotal.Text = "RS 80,99";
                CResumoo.Text = " Boné Feminino preto - Tamanho unico.";
                ImgProdutos.Image = Properties.Resources.Boné;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                CValor.Text = "R$ 70,99";
                Ctotal.Text = "RS 70,99";
                CResumoo.Text = "Ideal para as suas atividades diárias, a Calça Legging Anitta é confeccionada em poliéster e spandex, é muito confortável e tem alta durabilidade. O design da calça e também o material utilizado fazem com que ela empine o seu bumbum. Use e abuse na academia e em todas as suas atividades físicas! Disponível em cinco cores para você combinar com todos os seus looks. ";
                ImgProdutos.Image = Properties.Resources.Calça;
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                CValor.Text = "R$ 20,00";
                Ctotal.Text = "R$ 20,00";
                CResumoo.Text = " Camisa Com Folhas Hawaii Masculina - GD024-5 ";
                ImgProdutos.Image = Properties.Resources.Camisa;
            }

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                CValor.Text = "R$ 95,00";
                Ctotal.Text = "R$ 95,00";
                CResumoo.Text = " Camisa Masculina Social Slim Mackay - Khaki ";
                ImgProdutos.Image = Properties.Resources.Camiseta;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                CValor.Text = "R$ 80,00";
                Ctotal.Text = "R$ 80,00";
                CResumoo.Text = " A JAQUETA BOMBER MASCULINA ROSWELL É A PEÇA QUE FALTAVA EM SEU GUARDA-ROUPAS, TODA FEITA EM POLIÉSTER E ALGODÃO, FAZ COM QUE A PEÇA FIQUE MAIS LEVE E MALEÁVEL. ELA FOI PENSADA PRA VOCÊ ENFRENTAR DIAS COM BAIXAS TEMPERATURAS SEM ABRIR MÃO DO ESTILO. ";
                ImgProdutos.Image = Properties.Resources.jaqueta;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                CValor.Text = "R$ 30,00";
                Ctotal.Text = "R$ 30,00";
                CResumoo.Text = " Meia Calça Arrastão Simplee - Malha Larga ";
                ImgProdutos.Image = Properties.Resources.Meia;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                CValor.Text = "R$ 75,00";
                Ctotal.Text = "R$ 75,00";
                CResumoo.Text = " Vestido Europa Curto Com Cinto - Azul ";
                ImgProdutos.Image = Properties.Resources.Vestido;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                CValor.Text = "R$ 75,00";
                Ctotal.Text = "R$ 75,00";
                CResumoo.Text = " Vestido Europa Curto Com Cinto - Azul ";
                ImgProdutos.Image = Properties.Resources.Saia;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CNomeH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void CValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNAddCarrinho_Click(object sender, EventArgs e)
        {

            //Ativando botão Comprar
            if (BTNAddCarrinho.Enabled)
            {
                BTNComprar.Enabled = true;
            }



            if (GrupoBoxProdutos.Enabled) return;
            //GrupoBoxProdutos.Enabled = CCarrinho;
            ImgProdutos.Image = Properties.Resources.Agasalho;


        }

        private void CNomeH_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ola_Click(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tamanho_Enter(object sender, EventArgs e)
        {


        }

        private void PP_CheckedChanged(object sender, EventArgs e)
        {
            if (PP.Checked)
                CResumo2.Text = " Tamanho - PP | Peito:102cm | Ombro:44cm | Comprimento:63cm | Manga:62cm ";

        }
        private void M_CheckedChanged(object sender, EventArgs e)
        {
            if (M.Checked)
                CResumo2.Text = " Tamanho - M | Cintura: 80cm |Comprimento: 54cm ";
        }

        private void P_CheckedChanged(object sender, EventArgs e)
        {
            if (P.Checked)
                CResumo2.Text = " Tamanho - P | Cintura: 62-72cm |Comprimento: 72-92cm ";
        }

        private void G_CheckedChanged(object sender, EventArgs e)
        {
            if (G.Checked)
                CResumo2.Text = " Tamanho - G | Cintura: 68-76cm |Comprimento: 78-96cm ";
        }

        private void GG_CheckedChanged(object sender, EventArgs e)
        {
            if (GG.Checked)
                CResumo2.Text = " Tamanho - GG | Cintura: 70-78cm |Comprimento: 80-98cm ";
        }
        private void XGG_CheckedChanged(object sender, EventArgs e)
        {
            if (XGG.Checked)
                CResumo2.Text = " Tamanho - XGG | Peito:300cm | Ombro:64cm | Comprimento:83cm | Manga:82cm ";
        }



    }
}
