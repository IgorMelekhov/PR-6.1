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
   
    public partial class Form1 : Form
    {
        public static int place;
        int secondToClose;
        Timer timer;
        Form2 newF=new Form2();
        Form3 form3 = new Form3();
        List<string> items1=new List<string>() {" ","Москва","Норильск"};
        Dictionary<string, List<string>> items2 = new Dictionary<string, List<string>>()
        {
            {" ",new List<string>() {" "} },
            {"Москва",new List<string>() {"Владивосток","Мурманск"} },
            {"Норильск",new List<string>() {"Архангельск","Калининград"}}
        };
        public Form1()
        {
            InitializeComponent();
            comboBoxFrom.DataSource = items1;
            comboBoxFrom.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem=comboBoxFrom.SelectedItem.ToString();
            comboBoxWhere.DataSource = items2[selectItem];
        }
        private void Go_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedIndex == 0)
            {
                MessageBox.Show("Выберете место отправления пожалуйста", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((comboBoxFrom.SelectedIndex == 1) && (comboBoxWhere.SelectedIndex == 0))
            {
                place = 1;
                secondToClose = 1;
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += TimerTick;
                newF.Show();
                timer.Start();
            }
            if ((comboBoxFrom.SelectedIndex == 1) && (comboBoxWhere.SelectedIndex == 1))
            {
                secondToClose = 5;
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += TimerTick;
                newF.Show();
                timer.Start();
            }
            if ((comboBoxFrom.SelectedIndex == 2) && (comboBoxWhere.SelectedIndex == 0))
            {
                secondToClose = 12;
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += TimerTick;
                newF.Show();
                timer.Start();
            }
            if ((comboBoxFrom.SelectedIndex == 2) && (comboBoxWhere.SelectedIndex == 1))
            {
                secondToClose = 15;
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += TimerTick;
                newF.Show();
                timer.Start();
            }
        }
        private void TimerTick(object sender, EventArgs e)
        {
            secondToClose--;
            if (secondToClose == 0) 
            {
                timer.Stop();
                newF.Close();
                form3.Show();
            }
        }
    }
}
