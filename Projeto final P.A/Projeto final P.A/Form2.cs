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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 cliente = new Form1();
                cliente.ShowDialog();
                this.Close();
            }
        }
      

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, rg, cpf, email, endereco, bairro, cidade, numero, estado, cep, senha, confisenhas;
                nome = textBox1.Text;
                rg = textBox5.Text;
                cpf = maskedTextBox1.Text;
                email = textBox4.Text;
                endereco = textBox2.Text;
                bairro = textBox8.Text;
                cidade = textBox7.Text;
                numero = textBox3.Text;
                estado = comboBox1.Text;
                cep = maskedTextBox3.Text;
                senha = textBox9.Text;
                confisenhas = textBox11.Text;
                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Digite o seu nome")
                {
                    throw new Exception("Preencha o campo Nome ");
                }
                if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text == "Digite o seu rg")
                {
                    throw new Exception("Preencha o campo rg ");
                }
                
                if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || maskedTextBox1.Text == "Digite o seu cpf")
                {
                    throw new Exception("Preencha o campo cpf ");
                }
                try
                {
                    Convert.ToInt64(cpf);
                }
                catch
                {
                    throw new Exception("Cpf deve ser numeros");

                }
                if (cpf.Length != 11)
                {
                    throw new Exception("Cpf deve ter 13 digitos");
                }
                if (string.IsNullOrWhiteSpace(textBox4.Text) || textBox4.Text == "Digite o seu email")
                {
                  throw new Exception("Preencha o campo email");
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Digite o seu endereço")
                {
                    throw new Exception("Preencha o campo endereço");
                }
                if (string.IsNullOrWhiteSpace(textBox8.Text) || textBox8.Text == "Digite o seu bairro")
                {
                    throw new Exception("Preencha o campo bairro");
                }
                if (string.IsNullOrWhiteSpace(textBox7.Text) || textBox7.Text == "Digite a sua cidade")
                {
                    throw new Exception("Preencha o campo cidade");
                }
                if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Digite o numero de sua residencia")
                {
                    throw new Exception("Preencha o campo numero");
                }
                try
                {
                    Convert.ToInt64(numero);
                }
                catch
                {
                    throw new Exception("O campo Numero deve só conter numeros");
                }
                if (string.IsNullOrWhiteSpace(comboBox1.Text) || comboBox1.Text == "Digite o seu Estado")
                {
                    throw new Exception("Preencha o campo Estado ");
                }
                if (string.IsNullOrWhiteSpace(maskedTextBox3.Text) || maskedTextBox3.Text == "Digite o seu cep")
                {
                    throw new Exception("Preencha o campo cep ");
                }
                if (cep.Length != 8)
                {
                    throw new Exception("Cep deve ter 8 digitos");
                }
                try
                {
                    string sexo;
                    if (radioButton1.Checked == true)
                    {
                        sexo = radioButton1.Text;
                    }
                    if (radioButton2.Checked == true)
                    {
                        sexo = radioButton1.Text;
                    }
                    if (radioButton3.Checked == true)
                    {
                        sexo = radioButton1.Text;
                    }
                }
                catch
                {
                    throw new Exception("O campo sexo deve ser preenchido");

                }
                if (string.IsNullOrWhiteSpace(textBox9.Text) || textBox9.Text == "Digite a sua senha")
                {
                    throw new Exception("Preencha o campo senha ");
                }
                if (string.IsNullOrWhiteSpace(textBox11.Text) || textBox11.Text == "Digite o Tipo")
                {
                    throw new Exception("Preencha o campo Confirmar Senha ");
                }
                if( senha == confisenhas)
                {
                    
                }
                else
                {
                    throw new Exception("senha diferente");
                }

                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                maskedTextBox1.Clear();
                maskedTextBox3.Clear();
                textBox11.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                comboBox1.SelectedIndex = -1;
                textBox1.Focus();
            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
            maskedTextBox3.Clear();
            textBox11.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 cliente = new Form1();
                cliente.ShowDialog();
                this.Close();
            }

        }
    }
}
