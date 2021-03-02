using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotnetlogger;

namespace logger_test
{
    public partial class Form1 : Form
    {
        DotNetLogger logger = new DotNetLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Log(textBox1.Text.Trim());
        }
    }
}
