﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        #region Делегаты
        private EventHandler start;
        private EventHandler stop;
        private EventHandler reset;
        #endregion

        #region События
        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }

        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }

        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }
        #endregion

        #region Обработчики событий

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            start.Invoke(sender, e); //Вызов метода стартующего таймер
        }

        private void StopButon_Click_1(object sender, EventArgs e)
        {
            stop.Invoke(sender, e); //Вызов метода останавливающего таймер
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            reset.Invoke(sender, e); //Вызов метода обнуляющего таймер
        }
        #endregion
    }
}
