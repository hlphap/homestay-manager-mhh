namespace Hotel_Management.GUI_SoDoPhong
{
    partial class GUI_SoDoPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_SoDoPhong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.flpnl_sodophong = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox10 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_Search = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // flpnl_sodophong
            // 
            this.flpnl_sodophong.AutoScroll = true;
            this.flpnl_sodophong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnl_sodophong.Location = new System.Drawing.Point(0, 98);
            this.flpnl_sodophong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpnl_sodophong.Name = "flpnl_sodophong";
            this.flpnl_sodophong.Size = new System.Drawing.Size(1038, 577);
            this.flpnl_sodophong.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(124, 25);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Sơ đồ phòng";
            // 
            // bunifuMaterialTextbox10
            // 
            this.bunifuMaterialTextbox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox10.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox10.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.bunifuMaterialTextbox10.HintText = "Số phòng";
            this.bunifuMaterialTextbox10.isPassword = false;
            this.bunifuMaterialTextbox10.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.bunifuMaterialTextbox10.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.bunifuMaterialTextbox10.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.bunifuMaterialTextbox10.LineThickness = 1;
            this.bunifuMaterialTextbox10.Location = new System.Drawing.Point(106, 51);
            this.bunifuMaterialTextbox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuMaterialTextbox10.MaxLength = 32767;
            this.bunifuMaterialTextbox10.Name = "bunifuMaterialTextbox10";
            this.bunifuMaterialTextbox10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.bunifuMaterialTextbox10.Size = new System.Drawing.Size(115, 34);
            this.bunifuMaterialTextbox10.TabIndex = 132;
            this.bunifuMaterialTextbox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 131;
            this.label14.Text = "Số phòng: ";
            // 
            // bt_Search
            // 
            this.bt_Search.AllowToggling = false;
            this.bt_Search.AnimationSpeed = 200;
            this.bt_Search.AutoGenerateColors = false;
            this.bt_Search.BackColor = System.Drawing.Color.Transparent;
            this.bt_Search.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.bt_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Search.BackgroundImage")));
            this.bt_Search.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bt_Search.ButtonText = "Tìm kiếm";
            this.bt_Search.ButtonTextMarginLeft = 0;
            this.bt_Search.ColorContrastOnClick = 45;
            this.bt_Search.ColorContrastOnHover = 45;
            this.bt_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bt_Search.CustomizableEdges = borderEdges1;
            this.bt_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_Search.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bt_Search.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_Search.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_Search.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bt_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bt_Search.ForeColor = System.Drawing.Color.White;
            this.bt_Search.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Search.IconMarginLeft = 11;
            this.bt_Search.IconPadding = 10;
            this.bt_Search.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Search.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.bt_Search.IdleBorderRadius = 3;
            this.bt_Search.IdleBorderThickness = 1;
            this.bt_Search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.bt_Search.IdleIconLeftImage = null;
            this.bt_Search.IdleIconRightImage = null;
            this.bt_Search.IndicateFocus = false;
            this.bt_Search.Location = new System.Drawing.Point(242, 51);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Search.Name = "bt_Search";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bt_Search.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bt_Search.OnPressedState = stateProperties2;
            this.bt_Search.Size = new System.Drawing.Size(123, 34);
            this.bt_Search.TabIndex = 110;
            this.bt_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Search.TextMarginLeft = 0;
            this.bt_Search.UseDefaultRadiusAndThickness = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // GUI_SoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.bunifuMaterialTextbox10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.flpnl_sodophong);
            this.Name = "GUI_SoDoPhong";
            this.Size = new System.Drawing.Size(1038, 675);
            this.Load += new System.EventHandler(this.GUI_SoDoPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpnl_sodophong;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox10;
        private System.Windows.Forms.Label label14;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bt_Search;
    }
}
