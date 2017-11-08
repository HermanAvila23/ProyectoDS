namespace IU.USUARIO
{
    partial class FRM_USUARIO
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USUARIO));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.usuario1 = new IU.USUARIO.usuario();
            this.datos_usuario_label1 = new IU.USUARIO.Datos_usuario_label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.backstageViewClientControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL USUARIO";
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Appearance.BackColor = System.Drawing.Color.Blue;
            this.backstageViewControl1.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.backstageViewControl1.Appearance.Options.UseBackColor = true;
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(0, 47);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.SelectedTab = this.backstageViewTabItem1;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(883, 456);
            this.backstageViewControl1.TabIndex = 2;
            this.backstageViewControl1.Text = "backstageViewControl1";
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Controls.Add(this.panel2);
            this.backstageViewClientControl1.Location = new System.Drawing.Point(163, 0);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(720, 456);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 456);
            this.panel2.TabIndex = 0;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.usuario1);
            this.panel10.Controls.Add(this.windowsUIButtonPanel1);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(141, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(351, 456);
            this.panel10.TabIndex = 18;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.Gainsboro;
            windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            windowsUIButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions2.Image")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, false, "Guardar", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancelar", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, false, "Cancelar", -1, false)});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 379);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(351, 77);
            this.windowsUIButtonPanel1.TabIndex = 21;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(351, 39);
            this.panel11.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUARIO";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.datos_usuario_label1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(492, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 456);
            this.panel6.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATOS";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.simpleButton1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(141, 456);
            this.panel9.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(24, 379);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 69);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Modificar";
            this.simpleButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "USUARIO";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageViewTabItem1.Glyph")));
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = true;
            this.backstageViewTabItem1.SelectedChanged += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewTabItem1_SelectedChanged);
            // 
            // usuario1
            // 
            this.usuario1.Location = new System.Drawing.Point(47, 45);
            this.usuario1.Name = "usuario1";
            this.usuario1.Size = new System.Drawing.Size(277, 333);
            this.usuario1.TabIndex = 22;
            // 
            // datos_usuario_label1
            // 
            this.datos_usuario_label1.Location = new System.Drawing.Point(16, 53);
            this.datos_usuario_label1.Name = "datos_usuario_label1";
            this.datos_usuario_label1.Size = new System.Drawing.Size(200, 151);
            this.datos_usuario_label1.TabIndex = 4;
            // 
            // FRM_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 503);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_USUARIO";
            this.Text = "FRM_USUARIO";
            this.Load += new System.EventHandler(this.FRM_USUARIO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.backstageViewClientControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private usuario usuario1;
        private Datos_usuario_label datos_usuario_label1;

    }
}