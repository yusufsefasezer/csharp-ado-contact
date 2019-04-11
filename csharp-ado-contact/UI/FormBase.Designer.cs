namespace csharp_ado_contact
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.listBoxContactList = new System.Windows.Forms.ListBox();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxWebAddress = new System.Windows.Forms.TextBox();
            this.labelWebAddress = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.statusStripStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxContacts.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.statusStripStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxContacts
            // 
            this.groupBoxContacts.Controls.Add(this.listBoxContactList);
            this.groupBoxContacts.Location = new System.Drawing.Point(10, 5);
            this.groupBoxContacts.Name = "groupBoxContacts";
            this.groupBoxContacts.Size = new System.Drawing.Size(150, 300);
            this.groupBoxContacts.TabIndex = 1;
            this.groupBoxContacts.TabStop = false;
            this.groupBoxContacts.Text = "Contacts";
            // 
            // listBoxContactList
            // 
            this.listBoxContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContactList.FormattingEnabled = true;
            this.listBoxContactList.Location = new System.Drawing.Point(3, 16);
            this.listBoxContactList.Name = "listBoxContactList";
            this.listBoxContactList.Size = new System.Drawing.Size(144, 281);
            this.listBoxContactList.TabIndex = 0;
            this.listBoxContactList.SelectedIndexChanged += new System.EventHandler(this.listBoxContactList_SelectedIndexChanged);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.buttonNew);
            this.groupBoxInformation.Controls.Add(this.buttonUpdate);
            this.groupBoxInformation.Controls.Add(this.buttonDelete);
            this.groupBoxInformation.Controls.Add(this.textBoxNotes);
            this.groupBoxInformation.Controls.Add(this.labelNotes);
            this.groupBoxInformation.Controls.Add(this.textBoxAddress);
            this.groupBoxInformation.Controls.Add(this.labelAddress);
            this.groupBoxInformation.Controls.Add(this.textBoxWebAddress);
            this.groupBoxInformation.Controls.Add(this.labelWebAddress);
            this.groupBoxInformation.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxInformation.Controls.Add(this.labelPhoneNumber);
            this.groupBoxInformation.Controls.Add(this.textBoxEmail);
            this.groupBoxInformation.Controls.Add(this.labelEmail);
            this.groupBoxInformation.Controls.Add(this.textBoxLastName);
            this.groupBoxInformation.Controls.Add(this.labelLastName);
            this.groupBoxInformation.Controls.Add(this.textBoxFirstName);
            this.groupBoxInformation.Controls.Add(this.labelFirstName);
            this.groupBoxInformation.Location = new System.Drawing.Point(170, 5);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(300, 300);
            this.groupBoxInformation.TabIndex = 0;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Contact Information";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(57, 265);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "Add";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(138, 264);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(219, 264);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(94, 209);
            this.textBoxNotes.MaxLength = 80;
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(200, 50);
            this.textBoxNotes.TabIndex = 6;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(49, 209);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 0;
            this.labelNotes.Text = "Notes:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(94, 153);
            this.textBoxAddress.MaxLength = 80;
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 50);
            this.textBoxAddress.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(39, 153);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxWebAddress
            // 
            this.textBoxWebAddress.Location = new System.Drawing.Point(94, 127);
            this.textBoxWebAddress.MaxLength = 50;
            this.textBoxWebAddress.Name = "textBoxWebAddress";
            this.textBoxWebAddress.Size = new System.Drawing.Size(200, 20);
            this.textBoxWebAddress.TabIndex = 4;
            // 
            // labelWebAddress
            // 
            this.labelWebAddress.AutoSize = true;
            this.labelWebAddress.Location = new System.Drawing.Point(13, 131);
            this.labelWebAddress.Name = "labelWebAddress";
            this.labelWebAddress.Size = new System.Drawing.Size(74, 13);
            this.labelWebAddress.TabIndex = 0;
            this.labelWebAddress.Text = "Web Address:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(94, 101);
            this.textBoxPhoneNumber.MaxLength = 20;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(6, 105);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 0;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(94, 75);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(49, 79);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(94, 49);
            this.textBoxLastName.MaxLength = 40;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(26, 53);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(94, 23);
            this.textBoxFirstName.MaxLength = 40;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 27);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // statusStripStatus
            // 
            this.statusStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStripStatus.Location = new System.Drawing.Point(0, 309);
            this.statusStripStatus.Name = "statusStripStatus";
            this.statusStripStatus.Size = new System.Drawing.Size(484, 22);
            this.statusStripStatus.SizingGrip = false;
            this.statusStripStatus.TabIndex = 2;
            this.statusStripStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.statusStripStatus);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.groupBoxContacts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.Text = "ADO.NET Contact";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.groupBoxContacts.ResumeLayout(false);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.statusStripStatus.ResumeLayout(false);
            this.statusStripStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelWebAddress;
        private System.Windows.Forms.StatusStrip statusStripStatus;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxWebAddress;
        private System.Windows.Forms.ListBox listBoxContactList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
    }
}

