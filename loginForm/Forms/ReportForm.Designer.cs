namespace loginForm
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DTP_start = new Guna.UI.WinForms.GunaDateTimePicker();
            this.DTP_end = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.datagrid_Reports = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_show = new Guna.UI.WinForms.GunaGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Print = new Guna.UI.WinForms.GunaGradientButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_graphical = new Guna.UI.WinForms.GunaGradientButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_start
            // 
            this.DTP_start.BaseColor = System.Drawing.Color.White;
            this.DTP_start.BorderColor = System.Drawing.Color.Silver;
            this.DTP_start.CustomFormat = null;
            this.DTP_start.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTP_start.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP_start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTP_start.ForeColor = System.Drawing.Color.Black;
            this.DTP_start.Location = new System.Drawing.Point(23, 109);
            this.DTP_start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_start.Name = "DTP_start";
            this.DTP_start.OnHoverBaseColor = System.Drawing.Color.White;
            this.DTP_start.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP_start.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP_start.OnPressedColor = System.Drawing.Color.Black;
            this.DTP_start.Size = new System.Drawing.Size(261, 39);
            this.DTP_start.TabIndex = 0;
            this.DTP_start.Text = "Friday, 17 March 2023";
            this.DTP_start.Value = new System.DateTime(2023, 3, 17, 9, 3, 16, 716);
            // 
            // DTP_end
            // 
            this.DTP_end.BaseColor = System.Drawing.Color.White;
            this.DTP_end.BorderColor = System.Drawing.Color.Silver;
            this.DTP_end.CustomFormat = null;
            this.DTP_end.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTP_end.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP_end.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTP_end.ForeColor = System.Drawing.Color.Black;
            this.DTP_end.Location = new System.Drawing.Point(300, 109);
            this.DTP_end.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_end.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_end.Name = "DTP_end";
            this.DTP_end.OnHoverBaseColor = System.Drawing.Color.White;
            this.DTP_end.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP_end.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTP_end.OnPressedColor = System.Drawing.Color.Black;
            this.DTP_end.Size = new System.Drawing.Size(261, 39);
            this.DTP_end.TabIndex = 1;
            this.DTP_end.Text = "Friday, 17 March 2023";
            this.DTP_end.Value = new System.DateTime(2023, 3, 17, 9, 3, 28, 73);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Black", 25.8F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(2, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(373, 60);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "REPORT FORM";
            // 
            // datagrid_Reports
            // 
            this.datagrid_Reports.AllowUserToAddRows = false;
            this.datagrid_Reports.AllowUserToDeleteRows = false;
            this.datagrid_Reports.AllowUserToResizeColumns = false;
            this.datagrid_Reports.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid_Reports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Reports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Reports.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Reports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Reports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Reports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Reports.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Reports.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_Reports.EnableHeadersVisualStyles = false;
            this.datagrid_Reports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Reports.Location = new System.Drawing.Point(12, 182);
            this.datagrid_Reports.Name = "datagrid_Reports";
            this.datagrid_Reports.ReadOnly = true;
            this.datagrid_Reports.RowHeadersVisible = false;
            this.datagrid_Reports.RowHeadersWidth = 51;
            this.datagrid_Reports.RowTemplate.Height = 24;
            this.datagrid_Reports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Reports.Size = new System.Drawing.Size(989, 190);
            this.datagrid_Reports.TabIndex = 6;
            this.datagrid_Reports.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagrid_Reports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Reports.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid_Reports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid_Reports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid_Reports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid_Reports.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Reports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Reports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid_Reports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_Reports.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Reports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid_Reports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid_Reports.ThemeStyle.HeaderStyle.Height = 28;
            this.datagrid_Reports.ThemeStyle.ReadOnly = true;
            this.datagrid_Reports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid_Reports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid_Reports.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid_Reports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid_Reports.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid_Reports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid_Reports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_show
            // 
            this.btn_show.AnimationHoverSpeed = 0.07F;
            this.btn_show.AnimationSpeed = 0.03F;
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_show.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_show.BorderColor = System.Drawing.Color.Black;
            this.btn_show.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_show.FocusedColor = System.Drawing.Color.Empty;
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Image = null;
            this.btn_show.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_show.Location = new System.Drawing.Point(598, 109);
            this.btn_show.Name = "btn_show";
            this.btn_show.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_show.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_show.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btn_show.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_show.OnHoverImage = null;
            this.btn_show.OnPressedColor = System.Drawing.Color.Black;
            this.btn_show.Radius = 8;
            this.btn_show.Size = new System.Drawing.Size(160, 42);
            this.btn_show.TabIndex = 7;
            this.btn_show.Text = "Show";
            this.btn_show.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(296, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Date";
            // 
            // btn_Print
            // 
            this.btn_Print.AnimationHoverSpeed = 0.07F;
            this.btn_Print.AnimationSpeed = 0.03F;
            this.btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_Print.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_Print.BorderColor = System.Drawing.Color.Black;
            this.btn_Print.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Print.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Image = null;
            this.btn_Print.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Print.Location = new System.Drawing.Point(812, 98);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_Print.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_Print.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btn_Print.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Print.OnHoverImage = null;
            this.btn_Print.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Print.Radius = 8;
            this.btn_Print.Size = new System.Drawing.Size(160, 42);
            this.btn_Print.TabIndex = 10;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btn_graphical
            // 
            this.btn_graphical.AnimationHoverSpeed = 0.07F;
            this.btn_graphical.AnimationSpeed = 0.03F;
            this.btn_graphical.BackColor = System.Drawing.Color.Transparent;
            this.btn_graphical.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_graphical.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.btn_graphical.BorderColor = System.Drawing.Color.Black;
            this.btn_graphical.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_graphical.FocusedColor = System.Drawing.Color.Empty;
            this.btn_graphical.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graphical.ForeColor = System.Drawing.Color.White;
            this.btn_graphical.Image = null;
            this.btn_graphical.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_graphical.Location = new System.Drawing.Point(812, 38);
            this.btn_graphical.Name = "btn_graphical";
            this.btn_graphical.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_graphical.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.btn_graphical.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btn_graphical.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_graphical.OnHoverImage = null;
            this.btn_graphical.OnPressedColor = System.Drawing.Color.Black;
            this.btn_graphical.Radius = 8;
            this.btn_graphical.Size = new System.Drawing.Size(160, 42);
            this.btn_graphical.TabIndex = 11;
            this.btn_graphical.Text = "Chart";
            this.btn_graphical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_graphical.Click += new System.EventHandler(this.btn_graphical_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 378);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(989, 319);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1013, 759);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_graphical);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.datagrid_Reports);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DTP_end);
            this.Controls.Add(this.DTP_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker DTP_start;
        private Guna.UI.WinForms.GunaDateTimePicker DTP_end;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView datagrid_Reports;
        private Guna.UI.WinForms.GunaGradientButton btn_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton btn_Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI.WinForms.GunaGradientButton btn_graphical;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}