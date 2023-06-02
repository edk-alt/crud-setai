namespace SETAI
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_tavoloP = new System.Windows.Forms.TextBox();
            this.txt_telP = new System.Windows.Forms.TextBox();
            this.btn_salva_pers = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.btn_vis_pers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(38, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(38, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tavolo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(38, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_nome.Location = new System.Drawing.Point(122, 164);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(168, 28);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_tavoloP
            // 
            this.txt_tavoloP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_tavoloP.Location = new System.Drawing.Point(122, 254);
            this.txt_tavoloP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tavoloP.Name = "txt_tavoloP";
            this.txt_tavoloP.Size = new System.Drawing.Size(168, 28);
            this.txt_tavoloP.TabIndex = 7;
            // 
            // txt_telP
            // 
            this.txt_telP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_telP.Location = new System.Drawing.Point(122, 207);
            this.txt_telP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_telP.Name = "txt_telP";
            this.txt_telP.Size = new System.Drawing.Size(168, 28);
            this.txt_telP.TabIndex = 8;
            // 
            // btn_salva_pers
            // 
            this.btn_salva_pers.BackColor = System.Drawing.Color.Transparent;
            this.btn_salva_pers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btn_salva_pers.ForeColor = System.Drawing.Color.Black;
            this.btn_salva_pers.Location = new System.Drawing.Point(42, 308);
            this.btn_salva_pers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salva_pers.Name = "btn_salva_pers";
            this.btn_salva_pers.Size = new System.Drawing.Size(118, 46);
            this.btn_salva_pers.TabIndex = 9;
            this.btn_salva_pers.Text = "salva";
            this.btn_salva_pers.UseVisualStyleBackColor = false;
            this.btn_salva_pers.Click += new System.EventHandler(this.btn_salva_pers_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(359, 108);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(445, 355);
            this.lb.TabIndex = 10;
            // 
            // btn_vis_pers
            // 
            this.btn_vis_pers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btn_vis_pers.ForeColor = System.Drawing.Color.Black;
            this.btn_vis_pers.Location = new System.Drawing.Point(164, 308);
            this.btn_vis_pers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_vis_pers.Name = "btn_vis_pers";
            this.btn_vis_pers.Size = new System.Drawing.Size(151, 46);
            this.btn_vis_pers.TabIndex = 11;
            this.btn_vis_pers.Text = "visualizza persone";
            this.btn_vis_pers.UseVisualStyleBackColor = true;
            this.btn_vis_pers.Click += new System.EventHandler(this.btn_vis_pers_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(854, 509);
            this.Controls.Add(this.btn_vis_pers);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btn_salva_pers);
            this.Controls.Add(this.txt_telP);
            this.Controls.Add(this.txt_tavoloP);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Persone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_tavoloP;
        private System.Windows.Forms.TextBox txt_telP;
        private System.Windows.Forms.Button btn_salva_pers;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btn_vis_pers;
    }
}