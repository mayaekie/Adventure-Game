﻿namespace Adventure_Game
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
            this.SuspendLayout();
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.White;
            this.option2Button.Location = new System.Drawing.Point(79, 324);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(38, 37);
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
            this.option1Label.Location = new System.Drawing.Point(123, 260);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(340, 37);
            this.option1Label.TabIndex = 3;
            // 
            // option2Label
            // 
            this.option2Label.BackColor = System.Drawing.Color.White;
            this.option2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.option2Label.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.LightPink;
            this.option2Label.Location = new System.Drawing.Point(123, 324);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(340, 37);
            this.option2Label.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.LightPink;
            this.outputLabel.Location = new System.Drawing.Point(39, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(431, 108);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.White;
            this.option1Button.Location = new System.Drawing.Point(79, 260);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(38, 37);
            this.option1Button.TabIndex = 6;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(506, 409);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option2Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
    }
}

