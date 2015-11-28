namespace SSDproject2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox_random = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.button_coin = new System.Windows.Forms.Button();
            this.button_Die = new System.Windows.Forms.Button();
            this.button_gaus = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_random
            // 
            this.listBox_random.FormattingEnabled = true;
            this.listBox_random.Location = new System.Drawing.Point(12, 60);
            this.listBox_random.Name = "listBox_random";
            this.listBox_random.Size = new System.Drawing.Size(210, 225);
            this.listBox_random.TabIndex = 0;
            this.listBox_random.SelectedIndexChanged += new System.EventHandler(this.listBox_random_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ListBox of Objects:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEED:";
            // 
            // textBox_seed
            // 
            this.textBox_seed.Location = new System.Drawing.Point(283, 25);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(33, 20);
            this.textBox_seed.TabIndex = 3;
            this.textBox_seed.Text = "0";
            // 
            // button_coin
            // 
            this.button_coin.Location = new System.Drawing.Point(241, 60);
            this.button_coin.Name = "button_coin";
            this.button_coin.Size = new System.Drawing.Size(75, 23);
            this.button_coin.TabIndex = 4;
            this.button_coin.Text = "COIN";
            this.button_coin.UseVisualStyleBackColor = true;
            this.button_coin.Click += new System.EventHandler(this.button_coin_Click);
            // 
            // button_Die
            // 
            this.button_Die.Location = new System.Drawing.Point(241, 100);
            this.button_Die.Name = "button_Die";
            this.button_Die.Size = new System.Drawing.Size(75, 23);
            this.button_Die.TabIndex = 5;
            this.button_Die.Text = "DIE";
            this.button_Die.UseVisualStyleBackColor = true;
            this.button_Die.Click += new System.EventHandler(this.button_Die_Click);
            // 
            // button_gaus
            // 
            this.button_gaus.Location = new System.Drawing.Point(241, 148);
            this.button_gaus.Name = "button_gaus";
            this.button_gaus.Size = new System.Drawing.Size(75, 23);
            this.button_gaus.TabIndex = 6;
            this.button_gaus.Text = "GAUSSIAN";
            this.button_gaus.UseVisualStyleBackColor = true;
            this.button_gaus.Click += new System.EventHandler(this.button_gaus_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(487, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "RandomResult";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(472, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_stop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_stop.Location = new System.Drawing.Point(965, 36);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 71);
            this.button_stop.TabIndex = 8;
            this.button_stop.Text = "STOP";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 501);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_gaus);
            this.Controls.Add(this.button_Die);
            this.Controls.Add(this.button_coin);
            this.Controls.Add(this.textBox_seed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_random);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_random;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.Button button_coin;
        private System.Windows.Forms.Button button_Die;
        private System.Windows.Forms.Button button_gaus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_stop;
    }
}

