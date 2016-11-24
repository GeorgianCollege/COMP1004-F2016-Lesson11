using System;
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
    public partial class StartForm : BaseForm
    {
        public StartForm()
        {
            InitializeComponent();

            this.NextForm = new NextForm();
            this.NextForm.PreviousForm = this;
        }

       

    }
}
