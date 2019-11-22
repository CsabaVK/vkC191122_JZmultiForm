namespace _11_22_MultiForm
{
    partial class FrmMain
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
            this.lb_1 = new System.Windows.Forms.Label();
            this.bt_1 = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_1.Location = new System.Drawing.Point(12, 9);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(78, 24);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "Szöveg:";
            // 
            // bt_1
            // 
            this.bt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_1.Location = new System.Drawing.Point(6, 41);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(304, 42);
            this.bt_1.TabIndex = 1;
            this.bt_1.Text = "Gomb";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.Bt_1_Click);
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_1.Location = new System.Drawing.Point(112, 6);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(198, 29);
            this.tb_1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 93);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.lb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.TextBox tb_1;
    }
}

