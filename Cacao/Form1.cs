﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cacao.Sock;
namespace Cacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servidor ser = new Servidor();
            ser.Conect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Conect();
        } 
    }
}
