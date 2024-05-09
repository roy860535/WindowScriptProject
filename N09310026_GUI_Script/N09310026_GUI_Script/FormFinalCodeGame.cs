﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310026_GUI_Script
{
    public partial class FormFinalCodeGame : Form
    {
        
        
        public FormFinalCodeGame()
        {
            InitializeComponent();
        }
        public int randonNumber = 0;
        private void GameStartBTN_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int max = random.Next(0, 100);
            int min = random.Next(0, max);

            
            randonNumber = random.Next(min, max);
            
            GameIntroduction.Text = "以為你設置數據，請開始遊戲";
            GuessText.Text = "數值為" + min + "~" + max + "之間";
        }

        private void GameIntroduction_Click(object sender, EventArgs e)
        {

        }

        private void GuessText_Click(object sender, EventArgs e)
        {

        }

        private void AnswerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuessBTN_Click(object sender, EventArgs e)
        {
            if(AnswerText.Text == randonNumber.ToString())
            {
                GuessText.Text = "你贏了，答案是" + randonNumber;
            }
        }
    }
}
