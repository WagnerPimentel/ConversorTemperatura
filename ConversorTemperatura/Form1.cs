﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(txtCelsius.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            txtFahrenheit.Text = fahrenheit.ToString();
        }
    }
}
