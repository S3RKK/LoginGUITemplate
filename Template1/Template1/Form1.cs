using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template1
{
    public partial class Backround : Form
    {
        public Backround()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }
    }
}
