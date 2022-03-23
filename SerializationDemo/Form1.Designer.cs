namespace SerializationDemo
{
    partial class SerializForm
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
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnBianryRead = new System.Windows.Forms.Button();
            this.btnBianryWrite = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnJsonwrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(386, 297);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(226, 52);
            this.btnXmlRead.TabIndex = 0;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(153, 297);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(213, 52);
            this.btnXmlWrite.TabIndex = 1;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnBianryRead
            // 
            this.btnBianryRead.Location = new System.Drawing.Point(386, 234);
            this.btnBianryRead.Name = "btnBianryRead";
            this.btnBianryRead.Size = new System.Drawing.Size(226, 57);
            this.btnBianryRead.TabIndex = 2;
            this.btnBianryRead.Text = "Binary Read";
            this.btnBianryRead.UseVisualStyleBackColor = true;
            this.btnBianryRead.Click += new System.EventHandler(this.btnBianryRead_Click);
            // 
            // btnBianryWrite
            // 
            this.btnBianryWrite.Location = new System.Drawing.Point(153, 234);
            this.btnBianryWrite.Name = "btnBianryWrite";
            this.btnBianryWrite.Size = new System.Drawing.Size(213, 57);
            this.btnBianryWrite.TabIndex = 3;
            this.btnBianryWrite.Text = "Binary Write";
            this.btnBianryWrite.UseVisualStyleBackColor = true;
            this.btnBianryWrite.Click += new System.EventHandler(this.btnBianryWrite_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(353, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(170, 22);
            this.txtId.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(353, 166);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(170, 22);
            this.txtLocation.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(353, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 22);
            this.txtName.TabIndex = 6;
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(153, 355);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(213, 52);
            this.btnSoapWrite.TabIndex = 7;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(386, 355);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(226, 52);
            this.btnSoapRead.TabIndex = 8;
            this.btnSoapRead.Text = "SOAP Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnJsonwrite
            // 
            this.btnJsonwrite.Location = new System.Drawing.Point(153, 413);
            this.btnJsonwrite.Name = "btnJsonwrite";
            this.btnJsonwrite.Size = new System.Drawing.Size(213, 56);
            this.btnJsonwrite.TabIndex = 9;
            this.btnJsonwrite.Text = "JSON Write";
            this.btnJsonwrite.UseVisualStyleBackColor = true;
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(386, 413);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(226, 56);
            this.btnJsonRead.TabIndex = 10;
            this.btnJsonRead.Text = "JSON Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(222, 125);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(222, 82);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(47, 16);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "DeptId";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(222, 169);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(58, 16);
            this.locationLabel.TabIndex = 13;
            this.locationLabel.Text = "Location";
            // 
            // SerializForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 548);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonwrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBianryWrite);
            this.Controls.Add(this.btnBianryRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Name = "SerializForm";
            this.Text = "Serialization Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnBianryRead;
        private System.Windows.Forms.Button btnBianryWrite;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnJsonwrite;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label locationLabel;
    }
}

