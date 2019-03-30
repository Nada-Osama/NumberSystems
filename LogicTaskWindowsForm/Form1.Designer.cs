namespace LogicTaskWindowsForm
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
            this.decBtn = new System.Windows.Forms.Button();
            this.DecTextBox = new System.Windows.Forms.TextBox();
            this.BinTextBox = new System.Windows.Forms.TextBox();
            this.OctTextBox = new System.Windows.Forms.TextBox();
            this.HexTextBox = new System.Windows.Forms.TextBox();
            this.BinLabel = new System.Windows.Forms.Label();
            this.OctLabel = new System.Windows.Forms.Label();
            this.HexLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.binBtn = new System.Windows.Forms.Button();
            this.octBtn = new System.Windows.Forms.Button();
            this.hexBtn = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decBtn
            // 
            this.decBtn.BackColor = System.Drawing.Color.Wheat;
            this.decBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBtn.ForeColor = System.Drawing.Color.Crimson;
            this.decBtn.Location = new System.Drawing.Point(588, 49);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(94, 32);
            this.decBtn.TabIndex = 0;
            this.decBtn.Text = "Dec Convert";
            this.decBtn.UseVisualStyleBackColor = false;
            this.decBtn.Click += new System.EventHandler(this.DecConvertionBtn_Click);
            // 
            // DecTextBox
            // 
            this.DecTextBox.AcceptsReturn = true;
            this.DecTextBox.BackColor = System.Drawing.Color.Wheat;
            this.DecTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecTextBox.Location = new System.Drawing.Point(309, 49);
            this.DecTextBox.Multiline = true;
            this.DecTextBox.Name = "DecTextBox";
            this.DecTextBox.Size = new System.Drawing.Size(217, 32);
            this.DecTextBox.TabIndex = 1;
            this.DecTextBox.TextChanged += new System.EventHandler(this.DecTextBox_TextChanged);
            // 
            // BinTextBox
            // 
            this.BinTextBox.BackColor = System.Drawing.Color.Wheat;
            this.BinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinTextBox.Location = new System.Drawing.Point(309, 104);
            this.BinTextBox.Multiline = true;
            this.BinTextBox.Name = "BinTextBox";
            this.BinTextBox.Size = new System.Drawing.Size(217, 32);
            this.BinTextBox.TabIndex = 2;
            this.BinTextBox.TextChanged += new System.EventHandler(this.BinTextBox_TextChanged);
            // 
            // OctTextBox
            // 
            this.OctTextBox.BackColor = System.Drawing.Color.Wheat;
            this.OctTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OctTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OctTextBox.Location = new System.Drawing.Point(309, 160);
            this.OctTextBox.Multiline = true;
            this.OctTextBox.Name = "OctTextBox";
            this.OctTextBox.Size = new System.Drawing.Size(217, 32);
            this.OctTextBox.TabIndex = 3;
            this.OctTextBox.TextChanged += new System.EventHandler(this.OctTextBox_TextChanged);
            // 
            // HexTextBox
            // 
            this.HexTextBox.BackColor = System.Drawing.Color.Wheat;
            this.HexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexTextBox.Location = new System.Drawing.Point(309, 216);
            this.HexTextBox.Multiline = true;
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.Size = new System.Drawing.Size(217, 32);
            this.HexTextBox.TabIndex = 4;
            this.HexTextBox.TextChanged += new System.EventHandler(this.HexTextBox_TextChanged);
            // 
            // BinLabel
            // 
            this.BinLabel.AutoSize = true;
            this.BinLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinLabel.ForeColor = System.Drawing.Color.Crimson;
            this.BinLabel.Location = new System.Drawing.Point(239, 108);
            this.BinLabel.Name = "BinLabel";
            this.BinLabel.Size = new System.Drawing.Size(54, 21);
            this.BinLabel.TabIndex = 6;
            this.BinLabel.Text = "Bin :";
            this.BinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OctLabel
            // 
            this.OctLabel.AutoSize = true;
            this.OctLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OctLabel.ForeColor = System.Drawing.Color.Crimson;
            this.OctLabel.Location = new System.Drawing.Point(239, 164);
            this.OctLabel.Name = "OctLabel";
            this.OctLabel.Size = new System.Drawing.Size(50, 21);
            this.OctLabel.TabIndex = 7;
            this.OctLabel.Text = "Oct :";
            this.OctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexLabel.ForeColor = System.Drawing.Color.Crimson;
            this.HexLabel.Location = new System.Drawing.Point(239, 220);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(56, 21);
            this.HexLabel.TabIndex = 8;
            this.HexLabel.Text = "Hex :";
            this.HexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(239, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dec :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binBtn
            // 
            this.binBtn.BackColor = System.Drawing.Color.Wheat;
            this.binBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binBtn.ForeColor = System.Drawing.Color.Crimson;
            this.binBtn.Location = new System.Drawing.Point(588, 104);
            this.binBtn.Name = "binBtn";
            this.binBtn.Size = new System.Drawing.Size(93, 32);
            this.binBtn.TabIndex = 11;
            this.binBtn.Text = "Bin Convert";
            this.binBtn.UseVisualStyleBackColor = false;
            this.binBtn.Click += new System.EventHandler(this.BinConvertionBtn_Click);
            // 
            // octBtn
            // 
            this.octBtn.BackColor = System.Drawing.Color.Wheat;
            this.octBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octBtn.ForeColor = System.Drawing.Color.Crimson;
            this.octBtn.Location = new System.Drawing.Point(588, 160);
            this.octBtn.Name = "octBtn";
            this.octBtn.Size = new System.Drawing.Size(94, 32);
            this.octBtn.TabIndex = 12;
            this.octBtn.Text = "Oct Convert";
            this.octBtn.UseVisualStyleBackColor = false;
            this.octBtn.Click += new System.EventHandler(this.OctConvertionBtn_Click);
            // 
            // hexBtn
            // 
            this.hexBtn.BackColor = System.Drawing.Color.Wheat;
            this.hexBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBtn.ForeColor = System.Drawing.Color.Crimson;
            this.hexBtn.Location = new System.Drawing.Point(585, 216);
            this.hexBtn.Name = "hexBtn";
            this.hexBtn.Size = new System.Drawing.Size(97, 32);
            this.hexBtn.TabIndex = 13;
            this.hexBtn.Text = "Hex Convert";
            this.hexBtn.UseVisualStyleBackColor = false;
            this.hexBtn.Click += new System.EventHandler(this.HexConvertionBtn_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Blue;
            this.Reset.Location = new System.Drawing.Point(735, 291);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 64);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(884, 460);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.hexBtn);
            this.Controls.Add(this.octBtn);
            this.Controls.Add(this.binBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HexLabel);
            this.Controls.Add(this.OctLabel);
            this.Controls.Add(this.BinLabel);
            this.Controls.Add(this.HexTextBox);
            this.Controls.Add(this.OctTextBox);
            this.Controls.Add(this.BinTextBox);
            this.Controls.Add(this.DecTextBox);
            this.Controls.Add(this.decBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.TextBox DecTextBox;
        private System.Windows.Forms.TextBox BinTextBox;
        private System.Windows.Forms.TextBox OctTextBox;
        private System.Windows.Forms.TextBox HexTextBox;
        private System.Windows.Forms.Label DecLabel;
        private System.Windows.Forms.Label BinLabel;
        private System.Windows.Forms.Label OctLabel;
        private System.Windows.Forms.Label HexLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button binBtn;
        private System.Windows.Forms.Button octBtn;
        private System.Windows.Forms.Button hexBtn;
        private System.Windows.Forms.Button Reset;
    }
}

