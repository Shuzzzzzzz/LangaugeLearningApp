﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangaugeLearningApp
{
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            word.Show();
            this.Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            AllWords allWords = new AllWords();
            allWords.Show();
            this.Hide();
        }
    }
}
