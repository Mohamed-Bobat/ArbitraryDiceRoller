namespace ArbitraryDiceRoller
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Size = new System.Windows.Forms.MaskedTextBox();
            this.Mod = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Button();
            this.ResultList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DCValue = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.MaskedTextBox();
            this.DC = new System.Windows.Forms.CheckBox();
            this.Exploding = new System.Windows.Forms.CheckBox();
            this.Sum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Size
            // 
            this.Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(153, 75);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(55, 40);
            this.Size.TabIndex = 1;
            this.Size.Text = "20";
            // 
            // Mod
            // 
            this.Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mod.Location = new System.Drawing.Point(252, 75);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(55, 40);
            this.Mod.TabIndex = 2;
            this.Mod.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "±";
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(143, 158);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(75, 23);
            this.Roll.TabIndex = 5;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // ResultList
            // 
            this.ResultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultList.FormattingEnabled = true;
            this.ResultList.HorizontalScrollbar = true;
            this.ResultList.ItemHeight = 25;
            this.ResultList.Location = new System.Drawing.Point(28, 187);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(304, 229);
            this.ResultList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Arbitrary Dice Roller";
            // 
            // DCValue
            // 
            this.DCValue.Location = new System.Drawing.Point(179, 131);
            this.DCValue.Name = "DCValue";
            this.DCValue.Size = new System.Drawing.Size(48, 20);
            this.DCValue.TabIndex = 11;
            this.DCValue.Text = "0";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(50, 75);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(55, 40);
            this.Number.TabIndex = 12;
            this.Number.Text = "1";
            // 
            // DC
            // 
            this.DC.AutoSize = true;
            this.DC.Location = new System.Drawing.Point(132, 133);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(41, 17);
            this.DC.TabIndex = 13;
            this.DC.Text = "DC";
            this.DC.UseVisualStyleBackColor = true;
            // 
            // Exploding
            // 
            this.Exploding.AutoSize = true;
            this.Exploding.Location = new System.Drawing.Point(252, 135);
            this.Exploding.Name = "Exploding";
            this.Exploding.Size = new System.Drawing.Size(97, 17);
            this.Exploding.TabIndex = 14;
            this.Exploding.Text = "Exlpoding Dice";
            this.Exploding.UseVisualStyleBackColor = true;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(28, 135);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(47, 17);
            this.Sum.TabIndex = 15;
            this.Sum.Text = "Sum";
            this.Sum.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Exploding);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.DCValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Size);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Arbitrary Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Size;
        private System.Windows.Forms.MaskedTextBox Mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.ListBox ResultList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DCValue;
        private System.Windows.Forms.MaskedTextBox Number;
        private System.Windows.Forms.CheckBox DC;
        private System.Windows.Forms.CheckBox Exploding;
        private System.Windows.Forms.CheckBox Sum;
    }
}

