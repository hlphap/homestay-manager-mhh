namespace Hotel_Management.GUI_NghiepVuPhong
{
    partial class GUI_ListDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ListDV));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.PanelSub = new System.Windows.Forms.Panel();
            this.lb_MaDV = new System.Windows.Forms.Label();
            this.lb_GiaDV = new System.Windows.Forms.Label();
            this.lb_TenDV = new System.Windows.Forms.Label();
            this.bt_Xoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSub
            // 
            this.PanelSub.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PanelSub.Controls.Add(this.bt_Xoa);
            this.PanelSub.Controls.Add(this.lb_MaDV);
            this.PanelSub.Controls.Add(this.lb_GiaDV);
            this.PanelSub.Controls.Add(this.lb_TenDV);
            this.PanelSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSub.Location = new System.Drawing.Point(0, 0);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(987, 40);
            this.PanelSub.TabIndex = 24;
            // 
            // lb_MaDV
            // 
            this.lb_MaDV.AutoSize = true;
            this.lb_MaDV.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDV.Location = new System.Drawing.Point(15, 11);
            this.lb_MaDV.Name = "lb_MaDV";
            this.lb_MaDV.Size = new System.Drawing.Size(52, 20);
            this.lb_MaDV.TabIndex = 4;
            this.lb_MaDV.Text = "MaDV";
            // 
            // lb_GiaDV
            // 
            this.lb_GiaDV.AutoSize = true;
            this.lb_GiaDV.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiaDV.Location = new System.Drawing.Point(485, 11);
            this.lb_GiaDV.Name = "lb_GiaDV";
            this.lb_GiaDV.Size = new System.Drawing.Size(85, 20);
            this.lb_GiaDV.TabIndex = 3;
            this.lb_GiaDV.Text = "Giá dịch vụ";
            // 
            // lb_TenDV
            // 
            this.lb_TenDV.AutoSize = true;
            this.lb_TenDV.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDV.Location = new System.Drawing.Point(191, 11);
            this.lb_TenDV.Name = "lb_TenDV";
            this.lb_TenDV.Size = new System.Drawing.Size(87, 20);
            this.lb_TenDV.TabIndex = 2;
            this.lb_TenDV.Text = "Tên dịch vụ";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.AllowToggling = false;
            this.bt_Xoa.AnimationSpeed = 200;
            this.bt_Xoa.AutoGenerateColors = false;
            this.bt_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.bt_Xoa.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.BackgroundImage")));
            this.bt_Xoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bt_Xoa.ButtonText = "Xóa";
            this.bt_Xoa.ButtonTextMarginLeft = 0;
            this.bt_Xoa.ColorContrastOnClick = 45;
            this.bt_Xoa.ColorContrastOnHover = 45;
            this.bt_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bt_Xoa.CustomizableEdges = borderEdges1;
            this.bt_Xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_Xoa.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bt_Xoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bt_Xoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bt_Xoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bt_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.bt_Xoa.ForeColor = System.Drawing.Color.White;
            this.bt_Xoa.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Xoa.IconMarginLeft = 11;
            this.bt_Xoa.IconPadding = 10;
            this.bt_Xoa.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Xoa.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Xoa.IdleBorderRadius = 25;
            this.bt_Xoa.IdleBorderThickness = 2;
            this.bt_Xoa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Xoa.IdleIconLeftImage = null;
            this.bt_Xoa.IdleIconRightImage = null;
            this.bt_Xoa.IndicateFocus = false;
            this.bt_Xoa.Location = new System.Drawing.Point(791, 5);
            this.bt_Xoa.Name = "bt_Xoa";
            stateProperties1.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties1.BorderRadius = 25;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 2;
            stateProperties1.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(182)))), ((int)(((byte)(148)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bt_Xoa.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(147)))));
            stateProperties2.BorderRadius = 25;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 2;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(168)))), ((int)(((byte)(147)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bt_Xoa.OnPressedState = stateProperties2;
            this.bt_Xoa.Size = new System.Drawing.Size(100, 30);
            this.bt_Xoa.TabIndex = 22;
            this.bt_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Xoa.TextMarginLeft = 0;
            this.bt_Xoa.UseDefaultRadiusAndThickness = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // GUI_ListDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelSub);
            this.Name = "GUI_ListDV";
            this.Size = new System.Drawing.Size(987, 40);
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSub;
        public System.Windows.Forms.Label lb_MaDV;
        public System.Windows.Forms.Label lb_GiaDV;
        public System.Windows.Forms.Label lb_TenDV;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton bt_Xoa;
    }
}
