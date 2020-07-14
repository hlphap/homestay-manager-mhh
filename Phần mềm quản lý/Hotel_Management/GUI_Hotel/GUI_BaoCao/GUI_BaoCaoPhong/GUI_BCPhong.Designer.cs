namespace Hotel_Management.GUI_BaoCao.GUI_BaoCaoPhong
{
    partial class GUI_BCPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_BCPhong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Chart_BaoCao = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.bt_TimKiem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.datetime_NgaySau = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datetime_NgayTruoc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 25);
            this.bunifuCustomLabel1.TabIndex = 90;
            this.bunifuCustomLabel1.Text = "Báo cáo phòng";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thời gian";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lượt thuê phòng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số khách thuê";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Thời gian";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số khách thuê";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Chart_BaoCao);
            this.panel6.Location = new System.Drawing.Point(25, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(987, 483);
            this.panel6.TabIndex = 91;
            // 
            // Chart_BaoCao
            // 
            this.Chart_BaoCao.animationEnabled = false;
            this.Chart_BaoCao.AutoScroll = true;
            this.Chart_BaoCao.AxisLineColor = System.Drawing.Color.LightGray;
            this.Chart_BaoCao.AxisXFontColor = System.Drawing.Color.Gray;
            this.Chart_BaoCao.AxisXGridColor = System.Drawing.Color.Gray;
            this.Chart_BaoCao.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Chart_BaoCao.AxisYFontColor = System.Drawing.Color.Gray;
            this.Chart_BaoCao.AxisYGridColor = System.Drawing.Color.Gray;
            this.Chart_BaoCao.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Chart_BaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chart_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_BaoCao.Location = new System.Drawing.Point(0, 0);
            this.Chart_BaoCao.Name = "Chart_BaoCao";
            this.Chart_BaoCao.Size = new System.Drawing.Size(985, 481);
            this.Chart_BaoCao.TabIndex = 0;
            this.Chart_BaoCao.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.Chart_BaoCao.Title = "";
            this.Chart_BaoCao.Load += new System.EventHandler(this.Chart_BaoCao_Load);
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.AllowToggling = false;
            this.bt_TimKiem.AnimationSpeed = 200;
            this.bt_TimKiem.AutoGenerateColors = false;
            this.bt_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.bt_TimKiem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(89)))));
            this.bt_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_TimKiem.BackgroundImage")));
            this.bt_TimKiem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bt_TimKiem.ButtonText = "Tìm kiếm";
            this.bt_TimKiem.ButtonTextMarginLeft = 0;
            this.bt_TimKiem.ColorContrastOnClick = 45;
            this.bt_TimKiem.ColorContrastOnHover = 45;
            this.bt_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bt_TimKiem.CustomizableEdges = borderEdges1;
            this.bt_TimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_TimKiem.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bt_TimKiem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_TimKiem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_TimKiem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bt_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bt_TimKiem.ForeColor = System.Drawing.Color.White;
            this.bt_TimKiem.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_TimKiem.IconMarginLeft = 11;
            this.bt_TimKiem.IconPadding = 10;
            this.bt_TimKiem.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_TimKiem.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(89)))));
            this.bt_TimKiem.IdleBorderRadius = 3;
            this.bt_TimKiem.IdleBorderThickness = 1;
            this.bt_TimKiem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(89)))));
            this.bt_TimKiem.IdleIconLeftImage = null;
            this.bt_TimKiem.IdleIconRightImage = null;
            this.bt_TimKiem.IndicateFocus = false;
            this.bt_TimKiem.Location = new System.Drawing.Point(570, 87);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_TimKiem.Name = "bt_TimKiem";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bt_TimKiem.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bt_TimKiem.OnPressedState = stateProperties2;
            this.bt_TimKiem.Size = new System.Drawing.Size(116, 34);
            this.bt_TimKiem.TabIndex = 96;
            this.bt_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_TimKiem.TextMarginLeft = 0;
            this.bt_TimKiem.UseDefaultRadiusAndThickness = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Đến ngày";
            // 
            // datetime_NgaySau
            // 
            this.datetime_NgaySau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(89)))));
            this.datetime_NgaySau.BorderRadius = 0;
            this.datetime_NgaySau.ForeColor = System.Drawing.Color.White;
            this.datetime_NgaySau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_NgaySau.FormatCustom = null;
            this.datetime_NgaySau.Location = new System.Drawing.Point(310, 87);
            this.datetime_NgaySau.Margin = new System.Windows.Forms.Padding(5);
            this.datetime_NgaySau.Name = "datetime_NgaySau";
            this.datetime_NgaySau.Size = new System.Drawing.Size(235, 34);
            this.datetime_NgaySau.TabIndex = 94;
            this.datetime_NgaySau.Value = new System.DateTime(2019, 10, 11, 8, 17, 40, 675);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Từ ngày";
            // 
            // datetime_NgayTruoc
            // 
            this.datetime_NgayTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(107)))), ((int)(((byte)(89)))));
            this.datetime_NgayTruoc.BorderRadius = 0;
            this.datetime_NgayTruoc.ForeColor = System.Drawing.Color.White;
            this.datetime_NgayTruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_NgayTruoc.FormatCustom = null;
            this.datetime_NgayTruoc.Location = new System.Drawing.Point(25, 87);
            this.datetime_NgayTruoc.Margin = new System.Windows.Forms.Padding(5);
            this.datetime_NgayTruoc.Name = "datetime_NgayTruoc";
            this.datetime_NgayTruoc.Size = new System.Drawing.Size(235, 34);
            this.datetime_NgayTruoc.TabIndex = 92;
            this.datetime_NgayTruoc.Value = new System.DateTime(2019, 10, 11, 8, 17, 40, 675);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(393, 637);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(188, 20);
            this.bunifuCustomLabel2.TabIndex = 97;
            this.bunifuCustomLabel2.Text = "Biểu đồ doanh thu phòng";
            // 
            // GUI_BCPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetime_NgaySau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datetime_NgayTruoc);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "GUI_BCPhong";
            this.Size = new System.Drawing.Size(1038, 675);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.DataViz.WinForms.BunifuDataViz Chart_BaoCao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bt_TimKiem;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker datetime_NgaySau;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker datetime_NgayTruoc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}
