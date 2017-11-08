namespace IU.Ubicacion
{
    partial class frm_direccion
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_direccion));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.ubicacion1 = new IU.Ubicacion.ubicacion();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(499, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Direcion";
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.Gainsboro;
            windowsUIButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions4.Image")));
            windowsUIButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions5.Image")));
            windowsUIButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions6.Image")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar y Salir", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Guardar y Salir", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Limpiar", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Limpiar", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Cerrar", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Cerrar", -1, false)});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 298);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(499, 72);
            this.windowsUIButtonPanel1.TabIndex = 3;
            this.windowsUIButtonPanel1.Text = "c";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // ubicacion1
            // 
            this.ubicacion1.Location = new System.Drawing.Point(77, 53);
            this.ubicacion1.Margin = new System.Windows.Forms.Padding(2);
            this.ubicacion1.Name = "ubicacion1";
            this.ubicacion1.Size = new System.Drawing.Size(330, 234);
            this.ubicacion1.TabIndex = 2;
            // 
            // frm_direccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 370);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.ubicacion1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_direccion";
            this.Text = "frm_direccion";
            this.Load += new System.EventHandler(this.frm_direccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private ubicacion ubicacion1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}