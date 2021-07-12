using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos.WIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {


            button1.Location = new Point(button1.Location.X + 75, button1.Location.Y);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         string theMessage = Pos.BLL.Messages.GetMessage();
            DateTime theDateAndTime = DateTime.Now;
            MessageBox.Show($" {theMessage} {theDateAndTime}");
         
        //    MessageBox.Show(theDateAndTime.ToString());
        }
    }
}
