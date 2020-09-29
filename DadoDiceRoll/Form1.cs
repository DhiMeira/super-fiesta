using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadoDiceRoll
{
    public partial class Form1 : Form
    {
        List<string> rolagens = new List<string>();
        public Form1()
        {
            InitializeComponent();


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            

        }
        public void ListaRolagem()
        {
            
            listRolagem.Items.Clear();
            foreach(string r in rolagens)
            {
                listRolagem.Items.Add("Roll="+r);

                if (listRolagem.Items.Count >= 8)
                {
                    
                    listRolagem.Items.RemoveAt(0);
                }
            }
        }


        private void btnRoll_Click_1(object sender, EventArgs e)
        {
            Random randNum = new Random();
            if (rdD6.Checked)
            {
                txtRoll.Text = Convert.ToString(randNum.Next(1, 7));

                switch (txtRoll.Text)
                {
                    case "1":
                        txtRoll.ForeColor = Color.Red;
                        break;

                    case "6":
                        txtRoll.ForeColor = Color.Green;
                        break;
                    default:
                        txtRoll.ForeColor = Color.Black;
                        break;


                }

                rolagens.Add(txtRoll.Text);
                ListaRolagem();
            }
            if (rdD10.Checked)
            {
                txtRoll.Text = Convert.ToString(randNum.Next(1, 11));
                switch (txtRoll.Text)
                {
                    case "1":
                        txtRoll.ForeColor = Color.Red;
                        break;

                    case "10":
                        txtRoll.ForeColor = Color.Green;
                        break;
                    default:
                        txtRoll.ForeColor = Color.Black;
                        break;


                }

                rolagens.Add(txtRoll.Text);
                ListaRolagem();
            }
            if (rdD20.Checked)
            {
                txtRoll.Text = Convert.ToString(randNum.Next(1, 21));
                switch (txtRoll.Text)
                {
                    case "1":
                        txtRoll.ForeColor = Color.Red;
                        break;

                    case "20":
                        txtRoll.ForeColor = Color.Green;
                        break;
                    default:
                        txtRoll.ForeColor = Color.Black;
                        break;


                }

                rolagens.Add(txtRoll.Text);
                ListaRolagem();

            }


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DhiMeira?tab=repositories");
        }
    }
}
