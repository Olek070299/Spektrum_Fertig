
namespace Spektrum_Fertig
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.loadData = new System.Windows.Forms.Button();
            this.Offset_Abziehen = new System.Windows.Forms.Button();
            this.Segmentausschneiden = new System.Windows.Forms.Button();
            this.flag = new System.Windows.Forms.Button();
            this.eingabeflag = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.vonx1 = new System.Windows.Forms.TextBox();
            this.bisx2 = new System.Windows.Forms.TextBox();
            this.Wirkfunktion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Funktion_normiert = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.segmentierung_counts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Wirkfunktion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Funktion_normiert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentierung_counts)).BeginInit();
            this.SuspendLayout();
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(49, 23);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(75, 65);
            this.loadData.TabIndex = 0;
            this.loadData.Text = "LoadData";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // Offset_Abziehen
            // 
            this.Offset_Abziehen.Location = new System.Drawing.Point(49, 212);
            this.Offset_Abziehen.Name = "Offset_Abziehen";
            this.Offset_Abziehen.Size = new System.Drawing.Size(75, 72);
            this.Offset_Abziehen.TabIndex = 2;
            this.Offset_Abziehen.Text = "Offset_Abziehen";
            this.Offset_Abziehen.UseVisualStyleBackColor = true;
            this.Offset_Abziehen.Click += new System.EventHandler(this.Offset_Abziehen_Click);
            // 
            // Segmentausschneiden
            // 
            this.Segmentausschneiden.Location = new System.Drawing.Point(49, 303);
            this.Segmentausschneiden.Name = "Segmentausschneiden";
            this.Segmentausschneiden.Size = new System.Drawing.Size(75, 61);
            this.Segmentausschneiden.TabIndex = 3;
            this.Segmentausschneiden.Text = "Segmentausschneiden_Counts";
            this.Segmentausschneiden.UseVisualStyleBackColor = true;
            this.Segmentausschneiden.Click += new System.EventHandler(this.Segmentausschneiden_Click);
            // 
            // flag
            // 
            this.flag.Location = new System.Drawing.Point(376, 12);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(75, 66);
            this.flag.TabIndex = 4;
            this.flag.Text = "True(Fkt ist normiert)/false(nicht normiert)";
            this.flag.UseVisualStyleBackColor = true;
            // 
            // eingabeflag
            // 
            this.eingabeflag.Location = new System.Drawing.Point(457, 14);
            this.eingabeflag.Name = "eingabeflag";
            this.eingabeflag.Size = new System.Drawing.Size(100, 20);
            this.eingabeflag.TabIndex = 6;
            this.eingabeflag.Text = "True/false";
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(130, 257);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 7;
            this.x2.Text = "Bis x2";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(130, 221);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 22;
            this.x1.Text = "Von x1";
            // 
            // vonx1
            // 
            this.vonx1.Location = new System.Drawing.Point(130, 303);
            this.vonx1.Name = "vonx1";
            this.vonx1.Size = new System.Drawing.Size(100, 20);
            this.vonx1.TabIndex = 10;
            this.vonx1.Text = "von x1";
            // 
            // bisx2
            // 
            this.bisx2.Location = new System.Drawing.Point(130, 329);
            this.bisx2.Name = "bisx2";
            this.bisx2.Size = new System.Drawing.Size(100, 20);
            this.bisx2.TabIndex = 11;
            this.bisx2.Text = "Bis x2";
            // 
            // Wirkfunktion
            // 
            chartArea1.AxisX.Title = "Wellenlänge in nm";
            chartArea1.AxisY.Title = "Counts";
            chartArea1.Name = "ChartArea1";
            this.Wirkfunktion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Wirkfunktion.Legends.Add(legend1);
            this.Wirkfunktion.Location = new System.Drawing.Point(1042, 23);
            this.Wirkfunktion.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Wirkfunktion.Name = "Wirkfunktion";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Wirkfunktion";
            this.Wirkfunktion.Series.Add(series1);
            this.Wirkfunktion.Size = new System.Drawing.Size(328, 254);
            this.Wirkfunktion.TabIndex = 13;
            this.Wirkfunktion.Text = "Wirkfunktion";
            // 
            // Funktion_normiert
            // 
            chartArea2.AxisX.Title = "Wellenlänge";
            chartArea2.AxisY.Title = "Counts_Normiert";
            chartArea2.Name = "ChartArea1";
            this.Funktion_normiert.ChartAreas.Add(chartArea2);
            legend2.Name = "Normierte_Funktion";
            legend2.Title = "Normierte_Funktion";
            this.Funktion_normiert.Legends.Add(legend2);
            this.Funktion_normiert.Location = new System.Drawing.Point(689, 23);
            this.Funktion_normiert.Name = "Funktion_normiert";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Normierte_Funktion";
            series2.Name = "Series1";
            this.Funktion_normiert.Series.Add(series2);
            this.Funktion_normiert.Size = new System.Drawing.Size(315, 254);
            this.Funktion_normiert.TabIndex = 15;
            this.Funktion_normiert.Text = "Normierte_Funktion";
            title1.Name = "Normierte_Funktion";
            title1.Text = "Normierte_Funktion";
            this.Funktion_normiert.Titles.Add(title1);
            // 
            // chart1
            // 
            chartArea3.AxisX.Title = "Wellenlänge";
            chartArea3.AxisY.Title = "Counts_Offset";
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(1042, 329);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(340, 223);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // segmentierung_counts
            // 
            chartArea4.AxisX.Title = "Wellenlänge in nm";
            chartArea4.AxisY.Title = "Counts";
            chartArea4.Name = "ChartArea1";
            this.segmentierung_counts.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.segmentierung_counts.Legends.Add(legend4);
            this.segmentierung_counts.Location = new System.Drawing.Point(689, 329);
            this.segmentierung_counts.Name = "segmentierung_counts";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.segmentierung_counts.Series.Add(series4);
            this.segmentierung_counts.Size = new System.Drawing.Size(315, 223);
            this.segmentierung_counts.TabIndex = 19;
            this.segmentierung_counts.Text = "chart2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 23;
            this.button1.Text = "Neue_Console";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 96);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(457, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 433);
            this.listBox1.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 57);
            this.button3.TabIndex = 26;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 547);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Leistung eingeben";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 657);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.segmentierung_counts);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Funktion_normiert);
            this.Controls.Add(this.Wirkfunktion);
            this.Controls.Add(this.bisx2);
            this.Controls.Add(this.vonx1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.eingabeflag);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.Segmentausschneiden);
            this.Controls.Add(this.Offset_Abziehen);
            this.Controls.Add(this.loadData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Wirkfunktion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Funktion_normiert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentierung_counts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button Offset_Abziehen;
        private System.Windows.Forms.Button Segmentausschneiden;
        private System.Windows.Forms.Button flag;
        private System.Windows.Forms.TextBox eingabeflag;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox vonx1;
        private System.Windows.Forms.TextBox bisx2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wirkfunktion;
        private System.Windows.Forms.DataVisualization.Charting.Chart Funktion_normiert;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart segmentierung_counts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

