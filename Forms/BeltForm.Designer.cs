namespace ThirdLaboratory
{
    partial class BeltForm
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
            this.lName = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tProducer = new System.Windows.Forms.TextBox();
            this.lProducer = new System.Windows.Forms.Label();
            this.tMaterial = new System.Windows.Forms.TextBox();
            this.lMaterial = new System.Windows.Forms.Label();
            this.tBuckleMaterial = new System.Windows.Forms.TextBox();
            this.lBuckleMaterial = new System.Windows.Forms.Label();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.lBuckleType = new System.Windows.Forms.Label();
            this.cbBuckleType = new System.Windows.Forms.ComboBox();
            this.bContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(41, 48);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(45, 17);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(177, 48);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(120, 22);
            this.tName.TabIndex = 1;
            // 
            // tProducer
            // 
            this.tProducer.Location = new System.Drawing.Point(177, 76);
            this.tProducer.Name = "tProducer";
            this.tProducer.Size = new System.Drawing.Size(120, 22);
            this.tProducer.TabIndex = 3;
            // 
            // lProducer
            // 
            this.lProducer.AutoSize = true;
            this.lProducer.Location = new System.Drawing.Point(41, 76);
            this.lProducer.Name = "lProducer";
            this.lProducer.Size = new System.Drawing.Size(66, 17);
            this.lProducer.TabIndex = 2;
            this.lProducer.Text = "Producer";
            // 
            // tMaterial
            // 
            this.tMaterial.Location = new System.Drawing.Point(177, 104);
            this.tMaterial.Name = "tMaterial";
            this.tMaterial.Size = new System.Drawing.Size(120, 22);
            this.tMaterial.TabIndex = 5;
            // 
            // lMaterial
            // 
            this.lMaterial.AutoSize = true;
            this.lMaterial.Location = new System.Drawing.Point(41, 104);
            this.lMaterial.Name = "lMaterial";
            this.lMaterial.Size = new System.Drawing.Size(92, 17);
            this.lMaterial.TabIndex = 4;
            this.lMaterial.Text = "Main material";
            // 
            // tBuckleMaterial
            // 
            this.tBuckleMaterial.Location = new System.Drawing.Point(177, 132);
            this.tBuckleMaterial.Name = "tBuckleMaterial";
            this.tBuckleMaterial.Size = new System.Drawing.Size(120, 22);
            this.tBuckleMaterial.TabIndex = 7;
            // 
            // lBuckleMaterial
            // 
            this.lBuckleMaterial.AutoSize = true;
            this.lBuckleMaterial.Location = new System.Drawing.Point(41, 132);
            this.lBuckleMaterial.Name = "lBuckleMaterial";
            this.lBuckleMaterial.Size = new System.Drawing.Size(104, 17);
            this.lBuckleMaterial.TabIndex = 6;
            this.lBuckleMaterial.Text = "Buckle material";
            // 
            // tPrice
            // 
            this.tPrice.Location = new System.Drawing.Point(177, 160);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(120, 22);
            this.tPrice.TabIndex = 9;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(41, 160);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(40, 17);
            this.lPrice.TabIndex = 8;
            this.lPrice.Text = "Price";
            // 
            // lBuckleType
            // 
            this.lBuckleType.AutoSize = true;
            this.lBuckleType.Location = new System.Drawing.Point(41, 188);
            this.lBuckleType.Name = "lBuckleType";
            this.lBuckleType.Size = new System.Drawing.Size(81, 17);
            this.lBuckleType.TabIndex = 10;
            this.lBuckleType.Text = "Buckle type";
            // 
            // cbBuckleType
            // 
            this.cbBuckleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuckleType.FormattingEnabled = true;
            this.cbBuckleType.Location = new System.Drawing.Point(177, 189);
            this.cbBuckleType.Name = "cbBuckleType";
            this.cbBuckleType.Size = new System.Drawing.Size(121, 24);
            this.cbBuckleType.TabIndex = 11;
            // 
            // bContinue
            // 
            this.bContinue.Location = new System.Drawing.Point(110, 281);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(129, 36);
            this.bContinue.TabIndex = 12;
            this.bContinue.Text = "Save";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // BeltForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 358);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.cbBuckleType);
            this.Controls.Add(this.lBuckleType);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tBuckleMaterial);
            this.Controls.Add(this.lBuckleMaterial);
            this.Controls.Add(this.tMaterial);
            this.Controls.Add(this.lMaterial);
            this.Controls.Add(this.tProducer);
            this.Controls.Add(this.lProducer);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lName);
            this.Name = "BeltForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeltForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tProducer;
        private System.Windows.Forms.Label lProducer;
        private System.Windows.Forms.TextBox tMaterial;
        private System.Windows.Forms.Label lMaterial;
        private System.Windows.Forms.TextBox tBuckleMaterial;
        private System.Windows.Forms.Label lBuckleMaterial;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lBuckleType;
        private System.Windows.Forms.ComboBox cbBuckleType;
        private System.Windows.Forms.Button bContinue;
    }
}