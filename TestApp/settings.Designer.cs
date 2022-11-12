namespace TestApp
{
    partial class settings
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
            this.text_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // text_label
            // 
            this.text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.text_label.Location = new System.Drawing.Point(212, 162);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(331, 95);
            this.text_label.TabIndex = 0;
            this.text_label.Text = "settings";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_label);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.Timer timer1;
    }
}