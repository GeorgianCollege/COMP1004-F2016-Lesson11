﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson11
{
    public partial class BaseForm : Form
    {
        public BaseForm PreviousForm { get; set; }

        public BaseForm NextForm { get; set; }
        public BaseForm()
        {
            InitializeComponent();
        }

        public virtual void NextButton_Click(object sender, EventArgs e)
        {
            
            NextForm.Show();
            this.Hide();
        }

        public virtual void BackButton_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }
    }
}
