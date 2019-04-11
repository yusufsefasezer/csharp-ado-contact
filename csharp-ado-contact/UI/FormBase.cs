using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

namespace csharp_ado_contact
{
    public partial class FormBase : Form
    {
        public List<Contact> contactList = null;
        public DbProviderFactory dbProviderFactory;
        public static string dataProvider = string.Empty;
        public static string connectionString = string.Empty;
        public string STATUS
        {
            set
            {
                toolStripStatusLabelStatus.Text = value;
            }
        }

        protected FormBase()
        {
            InitializeComponent();
            contactList = new List<Contact>();
            dataProvider = Properties.Settings.Default.dataProvider;
            connectionString = Properties.Settings.Default.connectionString;
            dbProviderFactory = DbProviderFactories.GetFactory(dataProvider);
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            CheckConnection();
            LoadData();
            STATUS = "Contact list loaded successfully.";
        }

        private void CheckConnection()
        {
            var dbConnection = dbProviderFactory.CreateConnection();
            try
            {
                dbConnection.ConnectionString = connectionString;
                dbConnection.Open();
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        protected virtual void LoadData()
        {
            // Load DATA
            FillContactList();
        }

        protected virtual Contact GetContactById(int contactId)
        {
            // Get contact by id
            return null;
        }

        protected virtual void AddContact(Contact newContact)
        {
            // Add new contact
            contactList.Clear();
            LoadData();
        }

        protected virtual void UpdateContact(Contact updatedContact)
        {
            // Update new contact
            contactList.Clear();
            LoadData();
        }

        protected virtual void DeleteContactById(int contactId)
        {
            // Delete contact by id
            contactList.Clear();
            LoadData();
        }

        protected void FillContactList()
        {
            listBoxContactList.DataSource = null;
            listBoxContactList.DataSource = contactList;
            listBoxContactList.DisplayMember = "FullName";
            listBoxContactList.ValueMember = "contactId";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var newContact = new Contact
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Address = textBoxAddress.Text,
                WebAddress = textBoxWebAddress.Text,
                Notes = textBoxNotes.Text
            };
            AddContact(newContact);
            ResetInput();
        }

        private void ResetInput()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPhoneNumber.Clear();
            textBoxWebAddress.Clear();
            textBoxAddress.Clear();
            textBoxNotes.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxContactList.SelectedItems.Count == 0) return;
            int contactId = contactList[listBoxContactList.SelectedIndex].contactId;

            int selectedIndex = listBoxContactList.SelectedIndex;

            var updatedContact = new Contact
            {
                contactId = contactId,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Address = textBoxAddress.Text,
                WebAddress = textBoxWebAddress.Text,
                Notes = textBoxNotes.Text
            };
            UpdateContact(updatedContact);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxContactList.SelectedItems.Count == 0) return;
            int contactId = contactList[listBoxContactList.SelectedIndex].contactId;
            DeleteContactById(contactId);
            ResetInput();
        }

        private void listBoxContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContactList.SelectedItems.Count == 0) return;
            int contactId = contactList[listBoxContactList.SelectedIndex].contactId;
            Contact selectedContact = GetContactById(contactId);
            if (selectedContact == null) return;
            textBoxFirstName.Text = selectedContact.FirstName;
            textBoxLastName.Text = selectedContact.LastName;
            textBoxEmail.Text = selectedContact.Email;
            textBoxPhoneNumber.Text = selectedContact.PhoneNumber;
            textBoxWebAddress.Text = selectedContact.WebAddress;
            textBoxAddress.Text = selectedContact.Address;
            textBoxNotes.Text = selectedContact.Notes;
        }
    }
}
