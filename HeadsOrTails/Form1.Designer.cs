namespace HeadsOrTails
{
    partial class HeadsOrTails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadsOrTails));
            this.label1 = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heads Or Tails!";
            // 
            // Roll
            // 
            this.Roll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Roll.Cursor = System.Windows.Forms.Cursors.Default;
            this.Roll.Location = new System.Drawing.Point(170, 74);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(75, 23);
            this.Roll.TabIndex = 1;
            this.Roll.Text = "Go!";
            this.Roll.UseVisualStyleBackColor = false;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(13, 109);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(389, 440);
            this.outBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outBox.TabIndex = 2;
            this.outBox.TabStop = false;
            // 
            // HeadsOrTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(414, 561);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeadsOrTails";
            this.Text = "Heads Or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.PictureBox outBox;
    }
}