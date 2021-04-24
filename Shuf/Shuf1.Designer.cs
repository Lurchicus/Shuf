namespace Shuf
{
    partial class Shuf1
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
                DeckOfCards.Dispose();
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.Redeal = new System.Windows.Forms.Button();
            this.cbxDeck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text1.Location = new System.Drawing.Point(13, 36);
            this.text1.MaxLength = 0;
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text1.Size = new System.Drawing.Size(237, 530);
            this.text1.TabIndex = 0;
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Done.Location = new System.Drawing.Point(175, 572);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 1;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Redeal
            // 
            this.Redeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Redeal.Location = new System.Drawing.Point(12, 572);
            this.Redeal.Name = "Redeal";
            this.Redeal.Size = new System.Drawing.Size(75, 23);
            this.Redeal.TabIndex = 2;
            this.Redeal.Text = "Deal";
            this.Redeal.UseVisualStyleBackColor = true;
            this.Redeal.Click += new System.EventHandler(this.Redeal_Click);
            // 
            // cbxDeck
            // 
            this.cbxDeck.AutoSize = true;
            this.cbxDeck.Location = new System.Drawing.Point(13, 13);
            this.cbxDeck.Name = "cbxDeck";
            this.cbxDeck.Size = new System.Drawing.Size(116, 17);
            this.cbxDeck.TabIndex = 3;
            this.cbxDeck.Text = "Use alternate deck";
            this.cbxDeck.UseVisualStyleBackColor = true;
            this.cbxDeck.CheckedChanged += new System.EventHandler(this.cbxDeck_CheckedChanged);
            // 
            // Shuf1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 604);
            this.Controls.Add(this.cbxDeck);
            this.Controls.Add(this.Redeal);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.text1);
            this.Name = "Shuf1";
            this.Text = "Shuffler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Redeal;
        private System.Windows.Forms.CheckBox cbxDeck;
    }
}

