namespace ProyectoWindowsForm
{
    partial class FrmMenu
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
            this.controlPlantilla1 = new BibliotecaControlesFRM.ControlPlantilla();
            this.SuspendLayout();
            // 
            // controlPlantilla1
            // 
            this.controlPlantilla1.Location = new System.Drawing.Point(12, 23);
            this.controlPlantilla1.Name = "controlPlantilla1";
            this.controlPlantilla1.Size = new System.Drawing.Size(439, 393);
            this.controlPlantilla1.TabIndex = 0;
            this.controlPlantilla1.Load += new System.EventHandler(this.controlPlantilla1_Load);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 501);
            this.Controls.Add(this.controlPlantilla1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private BibliotecaControlesFRM.ControlPlantilla controlPlantilla1;
    }
}