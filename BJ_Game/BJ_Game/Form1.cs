﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BJ_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartScreen ecranAccueil = new StartScreen();
            ecranAccueil.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartScreen ecranAccueil = new StartScreen();
            ecranAccueil.Show();
            ecranAccueil.TopMost = true;
            ecranAccueil.Select();
        }
    }
}
