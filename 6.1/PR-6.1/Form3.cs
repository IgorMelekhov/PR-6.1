using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           if (Form1.place == 1)
            {
                pictureBoxPlace.Image = Image.FromFile(".\\Pictures\\Vlad.png");
                Welcome.Text = "Добро пожаловать во Владивосток";
            }

        }
    }
}
