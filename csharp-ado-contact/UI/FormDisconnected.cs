using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace csharp_ado_contact
{
    class FormDisconnected : FormBase
    {
        DataTable dataTable = null;
        DbDataAdapter dbDataAdapter = null;

        protected override void LoadData()
        {
            if (dataTable == null)
            {
                dataTable = new DataTable();
                var dbConnection = dbProviderFactory.CreateConnection();

                try
                {
                    dbConnection.ConnectionString = connectionString;
                    dbDataAdapter = dbProviderFactory.CreateDataAdapter();

                    var dbCommand = dbProviderFactory.CreateCommand();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "SELECT * FROM Contacts";
                    dbDataAdapter.SelectCommand = dbCommand;
                    dbDataAdapter.Fill(dataTable);

                    var dbCommandBuilder = dbProviderFactory.CreateCommandBuilder();
                    dbCommandBuilder.DataAdapter = dbDataAdapter;
                    dbDataAdapter.InsertCommand = dbCommandBuilder.GetInsertCommand();
                    dbDataAdapter.UpdateCommand = dbCommandBuilder.GetUpdateCommand();
                    dbDataAdapter.DeleteCommand = dbCommandBuilder.GetDeleteCommand();

                }
                catch (Exception ex)
                {
                    STATUS = ex.Message;
                }
            }

            foreach (DataRow Row in dataTable.Rows)
            {
                if (Row.RowState != DataRowState.Deleted)
                {
                    var tmpContact = new Contact
                    {
                        contactId = Convert.ToInt32(Row[0]),
                        FirstName = Row[1].ToString(),
                        LastName = Row[2].ToString(),
                        Email = Row[3].ToString(),
                        PhoneNumber = Row[4].ToString(),
                        Address = Row[5].ToString(),
                        WebAddress = Row[6].ToString(),
                        Notes = Row[7].ToString()
                    };
                    contactList.Add(tmpContact);
                }
            }

            base.LoadData();
        }

        protected override Contact GetContactById(int contactId)
        {
            Contact tmpContact = new Contact();
            string filter = "contactId=" + contactId;
            var rows = dataTable.Select(filter);
            tmpContact.contactId = Convert.ToInt32(rows[0][0]);
            tmpContact.FirstName = rows[0][1].ToString();
            tmpContact.LastName = rows[0][2].ToString();
            tmpContact.Email = rows[0][3].ToString();
            tmpContact.PhoneNumber = rows[0][4].ToString();
            tmpContact.Address = rows[0][5].ToString();
            tmpContact.WebAddress = rows[0][6].ToString();
            tmpContact.Notes = rows[0][7].ToString();
            return tmpContact;
        }

        protected override void AddContact(Contact newContact)
        {
            var dataRow = dataTable.NewRow();
            dataRow[0] = newContact.contactId;
            dataRow[1] = newContact.FirstName;
            dataRow[2] = newContact.LastName;
            dataRow[3] = newContact.Email;
            dataRow[4] = newContact.PhoneNumber;
            dataRow[5] = newContact.Address;
            dataRow[6] = newContact.WebAddress;
            dataRow[7] = newContact.Notes;
            dataTable.Rows.Add(dataRow);
            STATUS = "Contact added successfully.";
            base.AddContact(newContact);
        }

        protected override void UpdateContact(Contact updatedContact)
        {
            string filter = "contactId=" + updatedContact.contactId;
            var rows = dataTable.Select(filter);
            rows[0][0] = updatedContact.contactId;
            rows[0][1] = updatedContact.FirstName;
            rows[0][2] = updatedContact.LastName;
            rows[0][3] = updatedContact.Email;
            rows[0][4] = updatedContact.PhoneNumber;
            rows[0][5] = updatedContact.Address;
            rows[0][6] = updatedContact.WebAddress;
            rows[0][7] = updatedContact.Notes;
            STATUS = "Contact updated successfully.";
            base.UpdateContact(updatedContact);
        }

        protected override void DeleteContactById(int contactId)
        {
            string filter = "contactId=" + contactId;
            foreach (DataRow Row in dataTable.Select(filter))
            {
                Row.Delete();
            }
            STATUS = "Contact deleted successfully.";
            base.DeleteContactById(contactId);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            dbDataAdapter.Update(dataTable);
            base.OnClosing(e);
        }
    }
}
