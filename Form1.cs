using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDproject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       List<aRandomNumberGenerator> storageList = new List<aRandomNumberGenerator>();
        //aRandomNumberGenerator[] storageList = new aRandomNumberGenerator[5];
        
        int value;
        int pos =0;
        int theSeed;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int seedCheck()
        {
            if(textBox_seed.Text.Length==0)
            {
                return -1;
            }
            else
            {
                try
                {
                    Int32.Parse(textBox_seed.Text);
                    return 1;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Invalid seed. Try again");
                    return 0;
                }
            }
        }
        private void button_coin_Click(object sender, EventArgs e)
        {
            int hold = seedCheck();
            if(hold !=0 )
            {
                if(hold ==-1)
                {
                    theSeed =  DateTime.Now.Ticks.GetHashCode();
                }
                else if(hold==1)
                {
                    theSeed = Int32.Parse(textBox_seed.Text);
                }
                aCoin tmp = new aCoin(theSeed);
                listBox_random.Items.Add("Coin");
                storageList.Add(tmp);
            }
                     
        }

        private void button_Die_Click(object sender, EventArgs e)
        {
            int hold = seedCheck();
            if (hold != 0)
            {
                if (hold == -1)
                {
                    theSeed = DateTime.Now.Ticks.GetHashCode();
                }
                else if (hold == 1)
                {
                    theSeed = Int32.Parse(textBox_seed.Text);
                }
                aDie tmp = new aDie(theSeed);
                listBox_random.Items.Add("Die");
                storageList.Add(tmp);
            }
        }

        private void button_gaus_Click(object sender, EventArgs e)
        {
            int hold = seedCheck();
            if (hold != 0)
            {
                if (hold == -1)
                {
                    theSeed = DateTime.Now.Ticks.GetHashCode();
                }
                else if (hold == 1)
                {
                    theSeed = Int32.Parse(textBox_seed.Text);
                }
                aGaussian tmp = new aGaussian(theSeed);
                listBox_random.Items.Add("Gaussian");
                storageList.Add(tmp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            value = storageList[pos].Next();
   
            //chart1.Series["RandomResult"].Points.Clear();
            storageList[pos].rngResult[value] = storageList[pos].rngResult[value] +1;
            chart1.Series["RandomResult"].Points.AddXY(value, storageList[pos].rngResult[value]);
            string obj = listBox_random.SelectedItem.ToString();

            chart1.ChartAreas[0].AxisX.Maximum = storageList[listBox_random.SelectedIndex].High;
            chart1.ChartAreas[0].AxisX.Minimum = storageList[listBox_random.SelectedIndex].Low;
            chart1.Series["RandomResult"].Points.Clear();
            //rngResult is an int array storing how much each number has been called 
            for (int i = 0; i < storageList[listBox_random.SelectedIndex].rngResult.Length; i++)
            {
                chart1.Series["RandomResult"].Points.AddXY(i, storageList[pos].rngResult[i]);
            }
            
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string result ="";
            foreach (int i in  storageList[pos].rngResult)
            {
                result = result+ i.ToString()+" ";
            }
            MessageBox.Show(result);
        }

        private void listBox_random_SelectedIndexChanged(object sender, EventArgs e)
        {
             chart1.Series["RandomResult"].Points.Clear();
             pos = listBox_random.SelectedIndex;
             timer1.Start();
        }
        public void coinChart()
        {
            chart1.ChartAreas[0].AxisX.Maximum = 2;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.Series["RandomResult"].Points.Clear();
            //rngResult is an int array storing how much each number has been called 
            for(int i =0; i< storageList[listBox_random.SelectedIndex].rngResult.Length;i++)
            {
                chart1.Series["RandomResult"].Points.AddXY(i, storageList[pos].rngResult[i]);
            }
        }

        public void dieChart()
        {
            chart1.ChartAreas[0].AxisX.Maximum = 7;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.Series["RandomResult"].Points.Clear();
            for (int i = 0; i < storageList[listBox_random.SelectedIndex].rngResult.Length; i++)
            {
                chart1.Series["RandomResult"].Points.AddXY(i, storageList[pos].rngResult[i]);
            }
        }
        public void gaussianChart()
        {
            chart1.ChartAreas[0].AxisX.Maximum = 37;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.Series["RandomResult"].Points.Clear();
            for (int i = 0; i < storageList[listBox_random.SelectedIndex].rngResult.Length; i++)
            {
                chart1.Series["RandomResult"].Points.AddXY(i, storageList[pos].rngResult[i]);
            }
        }
    }
}
