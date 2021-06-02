namespace ThirdLaboratory
{
    partial class DressForm
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
            this.bContinue = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.tColor = new System.Windows.Forms.TextBox();
            this.lColor = new System.Windows.Forms.Label();
            this.tMaterial = new System.Windows.Forms.TextBox();
            this.lMaterial = new System.Windows.Forms.Label();
            this.tProducer = new System.Windows.Forms.TextBox();
            this.lProducer = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.tLength = new System.Windows.Forms.TextBox();
            this.lLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bContinue
            // 
            this.bContinue.Location = new System.Drawing.Point(110, 278);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(129, 36);
            this.bContinue.TabIndex = 25;
            this.bContinue.Text = "Save";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(177, 186);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 24;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(41, 185);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(76, 17);
            this.lType.TabIndex = 23;
            this.lType.Text = "Dress type";
            // 
            // tPrice
            // 
            this.tPrice.Location = new System.Drawing.Point(177, 157);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(120, 22);
            this.tPrice.TabIndex = 22;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(41, 157);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(40, 17);
            this.lPrice.TabIndex = 21;
            this.lPrice.Text = "Price";
            // 
            // tColor
            // 
            this.tColor.Location = new System.Drawing.Point(177, 129);
            this.tColor.Name = "tColor";
            this.tColor.Size = new System.Drawing.Size(120, 22);
            this.tColor.TabIndex = 20;
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(41, 129);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(41, 17);
            this.lColor.TabIndex = 19;
            this.lColor.Text = "Color";
            // 
            // tMaterial
            // 
            this.tMaterial.Location = new System.Drawing.Point(177, 101);
            this.tMaterial.Name = "tMaterial";
            this.tMaterial.Size = new System.Drawing.Size(120, 22);
            this.tMaterial.TabIndex = 18;
            // 
            // lMaterial
            // 
            this.lMaterial.AutoSize = true;
            this.lMaterial.Location = new System.Drawing.Point(41, 101);
            this.lMaterial.Name = "lMaterial";
            this.lMaterial.Size = new System.Drawing.Size(92, 17);
            this.lMaterial.TabIndex = 17;
            this.lMaterial.Text = "Main material";
            // 
            // tProducer
            // 
            this.tProducer.Location = new System.Drawing.Point(177, 73);
            this.tProducer.Name = "tProducer";
            this.tProducer.Size = new System.Drawing.Size(120, 22);
            this.tProducer.TabIndex = 16;
            // 
            // lProducer
            // 
            this.lProducer.AutoSize = true;
            this.lProducer.Location = new System.Drawing.Point(41, 73);
            this.lProducer.Name = "lProducer";
            this.lProducer.Size = new System.Drawing.Size(66, 17);
            this.lProducer.TabIndex = 15;
            this.lProducer.Text = "Producer";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(177, 45);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(120, 22);
            this.tName.TabIndex = 14;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(41, 45);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(45, 17);
            this.lName.TabIndex = 13;
            this.lName.Text = "Name";
            // 
            // tLength
            // 
            this.tLength.Location = new System.Drawing.Point(178, 216);
            this.tLength.Name = "tLength";
            this.tLength.Size = new System.Drawing.Size(120, 22);
            this.tLength.TabIndex = 27;
            // 
            // lLength
            // 
            this.lLength.AutoSize = true;
            this.lLength.Location = new System.Drawing.Point(42, 216);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(52, 17);
            this.lLength.TabIndex = 26;
            this.lLength.Text = "Length";
            // 
            // DressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 358);
            this.Controls.Add(this.tLength);
            this.Controls.Add(this.lLength);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tColor);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.tMaterial);
            this.Controls.Add(this.lMaterial);
            this.Controls.Add(this.tProducer);
            this.Controls.Add(this.lProducer);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lName);
            this.Name = "DressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.TextBox tColor;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.TextBox tMaterial;
        private System.Windows.Forms.Label lMaterial;
        private System.Windows.Forms.TextBox tProducer;
        private System.Windows.Forms.Label lProducer;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tLength;
        private System.Windows.Forms.Label lLength;
    }
}