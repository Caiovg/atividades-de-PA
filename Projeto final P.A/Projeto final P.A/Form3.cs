using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final_P.A
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
            Form1 cliente = new Form1();
            cliente.ShowDialog();
            this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras, nome, descrição, preco, estoque, unidade, tipo;
                codBarras = textBox3.Text;
                nome = textBox2.Text;
                descrição = textBox5.Text;
                preco = textBox6.Text;
                estoque = textBox4.Text;
                unidade = textBox1.Text;
                tipo = comboBox1.Text;
                if(string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Digite o código de barras")
                {
                    throw new Exception("Preencha o campo Codigo de barras ");
                }
                try
                {
                    
                    Convert.ToInt64(codBarras);
                    
                }
                catch
                {
                    throw new Exception("Codigo de Barras deve ser numeros");
                }
                if (codBarras.Length != 13)
                {
                    throw new Exception("Codigo de barras deve ter 13 digitos");
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Digite o nome")
                {
                    throw new Exception("Preencha o campo Nome");
                }
                if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text == "Digite a Descrição")
                {
                    throw new Exception("Preencha o campo Descrição ");
                }
                if (string.IsNullOrWhiteSpace(textBox6.Text) || textBox6.Text == "Digite o Preço")
                {
                    throw new Exception("Preencha o Preço ");
                }
                try
                {
                    Convert.ToDouble(preco);
                }
                catch
                {
                    throw new Exception("O preço so deve ter numeros reais");
                }
                if (string.IsNullOrWhiteSpace(textBox4.Text) || textBox4.Text == "Digite o Estoque")
                {
                    throw new Exception("Preencha o campo Estoque ");
                }
                try
                {
                    Convert.ToInt64(estoque);
                }
                catch
                {
                    throw new Exception("Estoque deve ser numeros");
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Digite a Unidade")
                {
                    throw new Exception("Preencha o campo Unidade ");
                }
                try
                {
                    Convert.ToInt64(unidade);
                }
                catch
                {
                    throw new Exception("Unidade deve ser numeros");
                }
                if (string.IsNullOrWhiteSpace(comboBox1.Text) || comboBox1.Text == "Digite o Tipo")
                {
                    throw new Exception("Preencha o campo Tipo ");
                }
                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  textBox1.Text = "";
                  textBox2.Clear();
                  textBox3.Clear();
                  textBox4.Clear();
                  textBox5.Clear();
                  textBox6.Clear();
                  comboBox1.SelectedIndex = -1;
                  textBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

         
    }
    
}
