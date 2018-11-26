using System.Web.UI.DataVisualization.Charting;

namespace OS_CursProject
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CPUusage = new System.Windows.Forms.TabPage();
            this.CPULabel = new MetroFramework.Controls.MetroLabel();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HDDusage = new System.Windows.Forms.TabPage();
            this.UIStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cpu1 = new MetroFramework.Controls.MetroLabel();
            this.cpu2 = new MetroFramework.Controls.MetroLabel();
            this.cpu3 = new MetroFramework.Controls.MetroLabel();
            this.cpu4 = new MetroFramework.Controls.MetroLabel();
            this.cpu5 = new MetroFramework.Controls.MetroLabel();
            this.cpu6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.value1 = new MetroFramework.Controls.MetroLabel();
            this.value2 = new MetroFramework.Controls.MetroLabel();
            this.value3 = new MetroFramework.Controls.MetroLabel();
            this.value4 = new MetroFramework.Controls.MetroLabel();
            this.value5 = new MetroFramework.Controls.MetroLabel();
            this.value6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CPUusage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIStyle)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tabControl1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 12);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(954, 620);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CPUusage);
            this.tabControl1.Controls.Add(this.HDDusage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 592);
            this.tabControl1.TabIndex = 2;
            // 
            // CPUusage
            // 
            this.CPUusage.Controls.Add(this.chartCPU);
            this.CPUusage.Controls.Add(this.metroPanel2);
            this.CPUusage.Location = new System.Drawing.Point(4, 29);
            this.CPUusage.Name = "CPUusage";
            this.CPUusage.Padding = new System.Windows.Forms.Padding(3);
            this.CPUusage.Size = new System.Drawing.Size(915, 559);
            this.CPUusage.TabIndex = 0;
            this.CPUusage.Text = "Мониторинг ЦП";
            this.CPUusage.UseVisualStyleBackColor = true;
            // 
            // CPULabel
            // 
            this.CPULabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.CPULabel.Location = new System.Drawing.Point(119, 2);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(339, 43);
            this.CPULabel.TabIndex = 1;
            this.CPULabel.Text = "Характеристики CPU";
            this.CPULabel.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // chartCPU
            // 
            this.chartCPU.BackColor = System.Drawing.Color.GhostWhite;
            this.chartCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartCPU.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chartCPU.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartCPU.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chartCPU.BorderSkin.BorderColor = System.Drawing.Color.SpringGreen;
            this.chartCPU.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chartCPU.BorderSkin.BorderWidth = 2;
            this.chartCPU.BorderSkin.PageColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.Interval = 2D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(221)))), ((int)(((byte)(201)))));
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorY.AutoScroll = false;
            chartArea1.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCPU.Legends.Add(legend1);
            this.chartCPU.Location = new System.Drawing.Point(6, 25);
            this.chartCPU.Name = "chartCPU";
            this.chartCPU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCPU.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series1.LabelForeColor = System.Drawing.Color.Bisque;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "CPU Usage";
            this.chartCPU.Series.Add(series1);
            this.chartCPU.Size = new System.Drawing.Size(906, 281);
            this.chartCPU.TabIndex = 0;
            this.chartCPU.Text = "chart1";
            title1.Font = new System.Drawing.Font("MS Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "Статистика загрузки ЦП";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Percent";
            title2.Position.Auto = false;
            title2.Position.Height = 84.57143F;
            title2.Position.Width = 4F;
            title2.Position.X = 3F;
            title2.Position.Y = 12.42857F;
            title2.Text = "Проценты %";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Frame;
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "CPUClock";
            title3.Position.Auto = false;
            title3.Position.Height = 10F;
            title3.Position.Width = 94F;
            title3.Position.X = 3F;
            title3.Position.Y = 90F;
            title3.Text = "Секунды";
            title3.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Frame;
            this.chartCPU.Titles.Add(title1);
            this.chartCPU.Titles.Add(title2);
            this.chartCPU.Titles.Add(title3);
            // 
            // HDDusage
            // 
            this.HDDusage.Location = new System.Drawing.Point(4, 29);
            this.HDDusage.Name = "HDDusage";
            this.HDDusage.Padding = new System.Windows.Forms.Padding(3);
            this.HDDusage.Size = new System.Drawing.Size(915, 559);
            this.HDDusage.TabIndex = 1;
            this.HDDusage.Text = "Мониторинг HDD";
            this.HDDusage.UseVisualStyleBackColor = true;
            // 
            // UIStyle
            // 
            this.UIStyle.Owner = this;
            this.UIStyle.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // cpu1
            // 
            this.cpu1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpu1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpu1.ForeColor = System.Drawing.Color.Black;
            this.cpu1.Location = new System.Drawing.Point(10, 45);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(189, 32);
            this.cpu1.TabIndex = 3;
            this.cpu1.Text = "Имя CPU: ";
            // 
            // cpu2
            // 
            this.cpu2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpu2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpu2.Location = new System.Drawing.Point(10, 79);
            this.cpu2.Name = "cpu2";
            this.cpu2.Size = new System.Drawing.Size(136, 31);
            this.cpu2.TabIndex = 4;
            this.cpu2.Text = "Архитектура:";
            this.cpu2.Click += new System.EventHandler(this.cpu2_Click);
            // 
            // cpu3
            // 
            this.cpu3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpu3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpu3.Location = new System.Drawing.Point(10, 112);
            this.cpu3.Name = "cpu3";
            this.cpu3.Size = new System.Drawing.Size(136, 27);
            this.cpu3.TabIndex = 5;
            this.cpu3.Text = "Подпись:";
            this.cpu3.Click += new System.EventHandler(this.cpu3_Click);
            // 
            // cpu4
            // 
            this.cpu4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpu4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpu4.Location = new System.Drawing.Point(10, 141);
            this.cpu4.Name = "cpu4";
            this.cpu4.Size = new System.Drawing.Size(178, 20);
            this.cpu4.TabIndex = 6;
            this.cpu4.Text = "Базовая частота: ";
            // 
            // cpu5
            // 
            this.cpu5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpu5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpu5.Location = new System.Drawing.Point(10, 163);
            this.cpu5.Name = "cpu5";
            this.cpu5.Size = new System.Drawing.Size(151, 33);
            this.cpu5.TabIndex = 7;
            this.cpu5.Text = "Ядра: ";
            // 
            // cpu6
            // 
            this.cpu6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpu6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpu6.Location = new System.Drawing.Point(10, 198);
            this.cpu6.Name = "cpu6";
            this.cpu6.Size = new System.Drawing.Size(169, 33);
            this.cpu6.TabIndex = 8;
            this.cpu6.Text = "Потоки: ";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.value6);
            this.metroPanel2.Controls.Add(this.value5);
            this.metroPanel2.Controls.Add(this.value4);
            this.metroPanel2.Controls.Add(this.value3);
            this.metroPanel2.Controls.Add(this.value2);
            this.metroPanel2.Controls.Add(this.value1);
            this.metroPanel2.Controls.Add(this.cpu5);
            this.metroPanel2.Controls.Add(this.cpu3);
            this.metroPanel2.Controls.Add(this.cpu4);
            this.metroPanel2.Controls.Add(this.cpu6);
            this.metroPanel2.Controls.Add(this.cpu2);
            this.metroPanel2.Controls.Add(this.CPULabel);
            this.metroPanel2.Controls.Add(this.cpu1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 312);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(551, 241);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // value1
            // 
            this.value1.AutoSize = true;
            this.value1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.value1.Location = new System.Drawing.Point(275, 43);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(68, 15);
            this.value1.TabIndex = 9;
            this.value1.Text = "metroLabel1";
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.value2.Location = new System.Drawing.Point(274, 74);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(70, 15);
            this.value2.TabIndex = 10;
            this.value2.Text = "metroLabel2";
            // 
            // value3
            // 
            this.value3.AutoSize = true;
            this.value3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.value3.Location = new System.Drawing.Point(274, 105);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(70, 15);
            this.value3.TabIndex = 11;
            this.value3.Text = "metroLabel3";
            // 
            // value4
            // 
            this.value4.AutoSize = true;
            this.value4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.value4.Location = new System.Drawing.Point(274, 136);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(70, 15);
            this.value4.TabIndex = 12;
            this.value4.Text = "metroLabel4";
            // 
            // value5
            // 
            this.value5.AutoSize = true;
            this.value5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.value5.Location = new System.Drawing.Point(274, 167);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(70, 15);
            this.value5.TabIndex = 13;
            this.value5.Text = "metroLabel5";
            // 
            // value6
            // 
            this.value6.AutoSize = true;
            this.value6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.value6.Location = new System.Drawing.Point(274, 198);
            this.value6.Name = "value6";
            this.value6.Size = new System.Drawing.Size(70, 15);
            this.value6.TabIndex = 14;
            this.value6.Text = "metroLabel6";
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.metroPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализатор ПК";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.CPUusage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIStyle)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Components.MetroStyleManager UIStyle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CPUusage;
        private System.Windows.Forms.TabPage HDDusage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private MetroFramework.Controls.MetroLabel CPULabel;
        private MetroFramework.Controls.MetroLabel cpu6;
        private MetroFramework.Controls.MetroLabel cpu5;
        private MetroFramework.Controls.MetroLabel cpu4;
        private MetroFramework.Controls.MetroLabel cpu3;
        private MetroFramework.Controls.MetroLabel cpu2;
        private MetroFramework.Controls.MetroLabel cpu1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel value6;
        private MetroFramework.Controls.MetroLabel value5;
        private MetroFramework.Controls.MetroLabel value4;
        private MetroFramework.Controls.MetroLabel value3;
        private MetroFramework.Controls.MetroLabel value2;
        private MetroFramework.Controls.MetroLabel value1;
    }
}

