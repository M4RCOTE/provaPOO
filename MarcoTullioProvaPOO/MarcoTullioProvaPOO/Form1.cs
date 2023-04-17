using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarcoTullioProvaPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioOnibus.Checked = true;
            textBoxPlaca.Mask = "000-0000";
        }

        
        //Usados
        private void buttonCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioOnibus.Checked == true)
            {
                Onibus onibus = new Onibus(textBoxPlaca.Text, Convert.ToInt32(textBoxAno.Text), Convert.ToInt32(textBoxDif.Text));
                
                ListViewItem oni = new ListViewItem("Onibus");

                oni.Checked = true;
                oni.SubItems.Add(onibus.Placa);
                oni.SubItems.Add(Convert.ToString(onibus.Ano));
                oni.SubItems.Add(Convert.ToString(onibus.Assentos));
                oni.SubItems.Add("----");
                oni.SubItems.Add("R$ " + Convert.ToString(onibus.Alugar()));

                listView1.Items.Add(oni);


            }
            else if (radioCaminhao.Checked == true)
            {
                Caminhao caminhao = new Caminhao(textBoxPlaca.Text, Convert.ToInt32(textBoxAno.Text), Convert.ToInt32(textBoxDif.Text));

                ListViewItem cam = new ListViewItem("Caminhão");

                cam.Checked = true;
                cam.SubItems.Add(caminhao.Placa);
                cam.SubItems.Add(Convert.ToString(caminhao.Ano));
                cam.SubItems.Add("----");
                cam.SubItems.Add(Convert.ToString(caminhao.Eixos));
                cam.SubItems.Add("R$ " + Convert.ToString(caminhao.Alugar()));

                listView1.Items.Add(cam);

            }
        }

        private void buttonLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Items.Clear();

        }
   
        private void radioOnibus_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.onibus;
            labelDif.Text = "Qtd Assentos";
        }
        
        private void radioCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.caminhao;
            labelDif.Text = "Qtd Eixos";
        }







        //Cliquei sem querer
        private void labelPlaca(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void radioOnibus_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
