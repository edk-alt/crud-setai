namespace SETAI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.zonax = new System.Windows.Forms.PictureBox();
            this.prive = new System.Windows.Forms.PictureBox();
            this.zonay = new System.Windows.Forms.PictureBox();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zonaz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zonax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaz)).BeginInit();
            this.SuspendLayout();
            // 
            // zonax
            // 
            this.zonax.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.zonax, "zonax");
            this.zonax.Name = "zonax";
            this.zonax.TabStop = false;
            this.zonax.Click += new System.EventHandler(this.zonax_Click);
            this.zonax.MouseLeave += new System.EventHandler(this.zonax_MouseLeave);
            this.zonax.MouseHover += new System.EventHandler(this.zonax_MouseHover);
            // 
            // prive
            // 
            this.prive.BackColor = System.Drawing.Color.Transparent;
            this.prive.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.prive, "prive");
            this.prive.Name = "prive";
            this.prive.TabStop = false;
            this.prive.Click += new System.EventHandler(this.prive_Click);
            this.prive.MouseLeave += new System.EventHandler(this.prive_MouseLeave);
            this.prive.MouseHover += new System.EventHandler(this.prive_MouseHover);
            // 
            // zonay
            // 
            this.zonay.BackColor = System.Drawing.Color.Transparent;
            this.zonay.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.zonay, "zonay");
            this.zonay.Name = "zonay";
            this.zonay.TabStop = false;
            this.zonay.MouseLeave += new System.EventHandler(this.zonay_MouseLeave);
            this.zonay.MouseHover += new System.EventHandler(this.zonay_MouseHover);
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btn_chiudi, "btn_chiudi");
            this.btn_chiudi.ForeColor = System.Drawing.Color.White;
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.UseVisualStyleBackColor = false;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // zonaz
            // 
            this.zonaz.BackColor = System.Drawing.Color.Transparent;
            this.zonaz.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.zonaz, "zonaz");
            this.zonaz.Name = "zonaz";
            this.zonaz.TabStop = false;
            this.zonaz.Click += new System.EventHandler(this.zonaz_Click);
            this.zonaz.MouseLeave += new System.EventHandler(this.zonaz_MouseLeave);
            this.zonaz.MouseHover += new System.EventHandler(this.zonaz_MouseHover);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zonaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.zonay);
            this.Controls.Add(this.prive);
            this.Controls.Add(this.zonax);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.zonax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zonax;
        private System.Windows.Forms.PictureBox prive;
        private System.Windows.Forms.PictureBox zonay;
        private System.Windows.Forms.Button btn_chiudi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox zonaz;
    }
}