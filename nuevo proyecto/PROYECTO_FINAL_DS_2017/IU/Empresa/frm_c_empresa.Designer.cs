namespace IU.Empresa
{
    partial class frm_c_empresa
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_c_empresa));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ubicacion1 = new IU.Ubicacion.ubicacion();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(534, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Empresa";
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.Gainsboro;
            windowsUIButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions5.Image")));
            windowsUIButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions6.Image")));
            windowsUIButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions7.Image")));
            windowsUIButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions8.Image")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Atras", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Siguiente", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, false, null, true, false, true, "Siguiente", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancelar", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Cancelar", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Guardar", -1, false)});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 343);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(534, 61);
            this.windowsUIButtonPanel1.TabIndex = 1;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ubicacion1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 302);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(414, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 302);
            this.panel2.TabIndex = 3;
            // 
            // ubicacion1
            // 
            this.ubicacion1.Location = new System.Drawing.Point(16, 35);
            this.ubicacion1.Margin = new System.Windows.Forms.Padding(2);
            this.ubicacion1.Name = "ubicacion1";
            this.ubicacion1.Size = new System.Drawing.Size(373, 234);
            this.ubicacion1.TabIndex = 0;
            // 
            // frm_c_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_c_empresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frm_c_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Ubicacion.ubicacion ubicacion1;
    }
}