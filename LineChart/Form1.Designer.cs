
namespace LineChart
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.m1DataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.m3DataGridViewTextBoxColumn,
            this.m4DataGridViewTextBoxColumn,
            this.m5DataGridViewTextBoxColumn,
            this.m6DataGridViewTextBoxColumn,
            this.m7DataGridViewTextBoxColumn,
            this.m8DataGridViewTextBoxColumn,
            this.m9DataGridViewTextBoxColumn,
            this.m10DataGridViewTextBoxColumn,
            this.m11DataGridViewTextBoxColumn,
            this.m12DataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.temperatureBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 327);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(769, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(769, 300);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(706, 488);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // m1DataGridViewTextBoxColumn
            // 
            this.m1DataGridViewTextBoxColumn.DataPropertyName = "M1";
            this.m1DataGridViewTextBoxColumn.HeaderText = "M1";
            this.m1DataGridViewTextBoxColumn.Name = "m1DataGridViewTextBoxColumn";
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "M2";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            // 
            // m3DataGridViewTextBoxColumn
            // 
            this.m3DataGridViewTextBoxColumn.DataPropertyName = "M3";
            this.m3DataGridViewTextBoxColumn.HeaderText = "M3";
            this.m3DataGridViewTextBoxColumn.Name = "m3DataGridViewTextBoxColumn";
            // 
            // m4DataGridViewTextBoxColumn
            // 
            this.m4DataGridViewTextBoxColumn.DataPropertyName = "M4";
            this.m4DataGridViewTextBoxColumn.HeaderText = "M4";
            this.m4DataGridViewTextBoxColumn.Name = "m4DataGridViewTextBoxColumn";
            // 
            // m5DataGridViewTextBoxColumn
            // 
            this.m5DataGridViewTextBoxColumn.DataPropertyName = "M5";
            this.m5DataGridViewTextBoxColumn.HeaderText = "M5";
            this.m5DataGridViewTextBoxColumn.Name = "m5DataGridViewTextBoxColumn";
            // 
            // m6DataGridViewTextBoxColumn
            // 
            this.m6DataGridViewTextBoxColumn.DataPropertyName = "M6";
            this.m6DataGridViewTextBoxColumn.HeaderText = "M6";
            this.m6DataGridViewTextBoxColumn.Name = "m6DataGridViewTextBoxColumn";
            // 
            // m7DataGridViewTextBoxColumn
            // 
            this.m7DataGridViewTextBoxColumn.DataPropertyName = "M7";
            this.m7DataGridViewTextBoxColumn.HeaderText = "M7";
            this.m7DataGridViewTextBoxColumn.Name = "m7DataGridViewTextBoxColumn";
            // 
            // m8DataGridViewTextBoxColumn
            // 
            this.m8DataGridViewTextBoxColumn.DataPropertyName = "M8";
            this.m8DataGridViewTextBoxColumn.HeaderText = "M8";
            this.m8DataGridViewTextBoxColumn.Name = "m8DataGridViewTextBoxColumn";
            // 
            // m9DataGridViewTextBoxColumn
            // 
            this.m9DataGridViewTextBoxColumn.DataPropertyName = "M9";
            this.m9DataGridViewTextBoxColumn.HeaderText = "M9";
            this.m9DataGridViewTextBoxColumn.Name = "m9DataGridViewTextBoxColumn";
            // 
            // m10DataGridViewTextBoxColumn
            // 
            this.m10DataGridViewTextBoxColumn.DataPropertyName = "M10";
            this.m10DataGridViewTextBoxColumn.HeaderText = "M10";
            this.m10DataGridViewTextBoxColumn.Name = "m10DataGridViewTextBoxColumn";
            // 
            // m11DataGridViewTextBoxColumn
            // 
            this.m11DataGridViewTextBoxColumn.DataPropertyName = "M11";
            this.m11DataGridViewTextBoxColumn.HeaderText = "M11";
            this.m11DataGridViewTextBoxColumn.Name = "m11DataGridViewTextBoxColumn";
            // 
            // m12DataGridViewTextBoxColumn
            // 
            this.m12DataGridViewTextBoxColumn.DataPropertyName = "M12";
            this.m12DataGridViewTextBoxColumn.HeaderText = "M12";
            this.m12DataGridViewTextBoxColumn.Name = "m12DataGridViewTextBoxColumn";
            // 
            // temperatureBindingSource
            // 
            this.temperatureBindingSource.DataSource = typeof(LineChart.Temperature);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 523);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m12DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource temperatureBindingSource;
    }
}

