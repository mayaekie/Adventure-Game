namespace Adventure_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.storyImage2 = new System.Windows.Forms.PictureBox();
            this.storyImage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storyImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.White;
            this.option2Button.Location = new System.Drawing.Point(105, 399);
            this.option2Button.Margin = new System.Windows.Forms.Padding(4);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(51, 46);
            this.option2Button.TabIndex = 0;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.BackColor = System.Drawing.Color.White;
            this.option1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.option1Label.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.LightPink;
            this.option1Label.Location = new System.Drawing.Point(164, 320);
            this.option1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(453, 46);
            this.option1Label.TabIndex = 3;
            // 
            // option2Label
            // 
            this.option2Label.BackColor = System.Drawing.Color.White;
            this.option2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.option2Label.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.LightPink;
            this.option2Label.Location = new System.Drawing.Point(164, 399);
            this.option2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(453, 46);
            this.option2Label.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.LightPink;
            this.outputLabel.Location = new System.Drawing.Point(52, 11);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(575, 133);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.White;
            this.option1Button.Location = new System.Drawing.Point(105, 320);
            this.option1Button.Margin = new System.Windows.Forms.Padding(4);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(51, 46);
            this.option1Button.TabIndex = 6;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // storyImage2
            // 
            this.storyImage2.Image = global::Adventure_Game.Properties.Resources.road;
            this.storyImage2.Location = new System.Drawing.Point(343, 159);
            this.storyImage2.Name = "storyImage2";
            this.storyImage2.Size = new System.Drawing.Size(173, 149);
            this.storyImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.storyImage2.TabIndex = 9;
            this.storyImage2.TabStop = false;
            // 
            // storyImage1
            // 
            this.storyImage1.Image = global::Adventure_Game.Properties.Resources.diner;
            this.storyImage1.Location = new System.Drawing.Point(164, 159);
            this.storyImage1.Name = "storyImage1";
            this.storyImage1.Size = new System.Drawing.Size(173, 149);
            this.storyImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.storyImage1.TabIndex = 8;
            this.storyImage1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(675, 503);
            this.Controls.Add(this.storyImage2);
            this.Controls.Add(this.storyImage1);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.storyImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.PictureBox storyImage1;
        private System.Windows.Forms.PictureBox storyImage2;
    }
}

