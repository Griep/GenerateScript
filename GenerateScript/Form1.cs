using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GenerateScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string TOnumber;
        private string Dev;
        private string Stg;
        private string Live;

        private void button1_Click(object sender, EventArgs e)
        {
            Generate Generate = new Generate();

            TOnumber = textboxTO.Text;
            Dev = textBoxDEV.Text;
            Stg = textBoxSTG.Text;
            Live = textBoxLIVE.Text;

            Generate.GenerateMethod(TOnumber, Dev, Stg, Live);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
