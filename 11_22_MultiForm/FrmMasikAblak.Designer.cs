namespace _11_22_MultiForm
{
    partial class FrmMasikAblak
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
            this.lb_masikform = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bt_masikform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_masikform
            // 
            this.lb_masikform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_masikform.Location = new System.Drawing.Point(12, 9);
            this.lb_masikform.Name = "lb_masikform";
            this.lb_masikform.Size = new System.Drawing.Size(398, 88);
            this.lb_masikform.TabIndex = 0;
            this.lb_masikform.Text = "Másik, középre igazított label";
            this.lb_masikform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_masikform
            // 
            this.bt_masikform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_masikform.Location = new System.Drawing.Point(16, 100);
            this.bt_masikform.Name = "bt_masikform";
            this.bt_masikform.Size = new System.Drawing.Size(394, 35);
            this.bt_masikform.TabIndex = 1;
            this.bt_masikform.Text = "Másik Gomb";
            this.bt_masikform.UseVisualStyleBackColor = true;
            this.bt_masikform.Click += new System.EventHandler(this.Bt_masikform_Click);
            // 
            // FrmMasikAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 223);
            this.Controls.Add(this.bt_masikform);
            this.Controls.Add(this.lb_masikform);
            this.Name = "FrmMasikAblak";
            this.Text = "FrmMasikAblak";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMasikAblak_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_masikform;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bt_masikform;
    }
}