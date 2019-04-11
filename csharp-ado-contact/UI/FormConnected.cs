using System;
using System.Data;
using System.Data.Common;

namespace csharp_ado_contact
{
    class FormConnected : FormBase
    {
        protected override void LoadData()
        {
            using (var dbConnection = dbProviderFactory.CreateConnection())
            {
                try
                {
                    dbConnection.ConnectionString = connectionString;
                    dbConnection.Open();

                    var dbCommand = dbProviderFactory.CreateCommand();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "SELECT * FROM Contacts";

                    var dbDataReader = dbCommand.ExecuteReader();
                    while (dbDataReader.Read())
                    {
                        var tmpContact = new Contact
                        {
                            contactId = dbDataReader.GetInt32(0),
                            FirstName = dbDataReader.GetString(1),
                            LastName = dbDataReader.GetString(2),
                            Email = dbDataReader.GetString(3),
                            PhoneNumber = dbDataReader.GetString(4),
                            Address = dbDataReader.GetString(5),
                            WebAddress = dbDataReader.GetString(6),
                            Notes = dbDataReader.GetString(7)
                        };
                        contactList.Add(tmpContact);
                    }

                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    STATUS = ex.Message;
                }
            }

            base.LoadData();
        }

        protected override Contact GetContactById(int contactId)
        {
            Contact tmpContact = new Contact();
            using (var dbConnection = dbProviderFactory.CreateConnection())
            {
                try
                {
                    dbConnection.ConnectionString = connectionString;
                    dbConnection.Open();

                    var dbCommand = dbProviderFactory.CreateCommand();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "SELECT * FROM Contacts WHERE ContactId = " + contactId;

                    var dbDataReader = dbCommand.ExecuteReader();
                    while (dbDataReader.Read())
                    {
                        tmpContact.contactId = dbDataReader.GetInt32(0);
                        tmpContact.FirstName = dbDataReader.GetString(1);
                        tmpContact.LastName = dbDataReader.GetString(2);
                        tmpContact.Email = dbDataReader.GetString(3);
                        tmpContact.PhoneNumber = dbDataReader.GetString(4);
                        tmpContact.Address = dbDataReader.GetString(5);
                        tmpContact.WebAddress = dbDataReader.GetString(6);
                        tmpContact.Notes = dbDataReader.GetString(7);
                    }

                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    STATUS = ex.Message;
                }
            }

            return tmpContact;
        }

        protected override void AddContact(Contact newContact)
        {
            Contact tmpContact = new Contact();
            using (var dbConnection = dbProviderFactory.CreateConnection())
            {
                try
                {
                    dbConnection.ConnectionString = connectionString;
                    dbConnection.Open();

                    var dbCommand = dbProviderFactory.CreateCommand();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "INSERT INTO Contacts(FirstName, LastName, Email, PhoneNumber, Address, WebAddress, Notes)"
                                                        + "VALUES(@FirstName, @LastName, @Email, @PhoneNumber, @Address, @WebAddress, @Notes)";

                    dbCommand.Parameters.Add(CreateParameter("@FirstName", newContact.FirstName, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@LastName", newContact.LastName, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@Email", newContact.Email, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@PhoneNumber", newContact.PhoneNumber, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@Address", newContact.Address, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@WebAddress", newContact.WebAddress, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@Notes", newContact.Notes, DbType.String));

                    if (dbCommand.ExecuteNonQuery() > 0)
                    {
                        STATUS = "Contact added successfully.";
                    }
                    else
                    {
                        throw new Exception("An error occurred.");
                    }

                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    STATUS = ex.Message;
                }
            }

            base.AddContact(newContact);
        }

        private DbParameter CreateParameter(string parameterName, object parameterValue, DbType parameterType)
        {
            var newParameter = dbProviderFactory.CreateParameter();
            newParameter.ParameterName = parameterName;
            newParameter.Value = parameterValue;
            newParameter.DbType = parameterType;
            return newParameter;
        }

        protected override void UpdateContact(Contact updatedContact)
        {
            Contact tmpContact = new Contact();
            using (var dbConnection = dbProviderFactory.CreateConnection())
            {
                try
                {
                    dbConnection.ConnectionString = connectionString;
                    dbConnection.Open();

                    var dbCommand = dbProviderFactory.CreateCommand();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "UPDATE Contacts SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address, WebAddress = @WebAddress, Notes = @Notes"
                                                        + " WHERE ContactId = @ContactId";

                    dbCommand.Parameters.Add(CreateParameter("@FirstName", updatedContact.FirstName, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@LastName", updatedContact.LastName, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@Email", updatedContact.Email, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@PhoneNumber", updatedContact.PhoneNumber, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@Address", updatedContact.Address, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@WebAddress", updatedContact.WebAddress, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@Notes", updatedContact.Notes, DbType.String));
                    dbCommand.Parameters.Add(CreateParameter("@ContactId", updatedContact.contactId, DbType.Int32));

                    if (dbCommand.ExecuteNonQuery() > 0)
                    {
                        STATUS = "Contact updated successfully.";
                    }
                    else
                    {
                        throw new Exception("An error occurred.");
                    }

                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    STATUS = ex.Message;
                }
            }

            base.UpdateContact(updatedContact);
        }

        protected override void DeleteContactById(int contactId)
        {
            using (var dbConnection = dbProviderFactory.CreateConnection())
            {
                try
                {
                    dbConnection.ConnectionString = connectionString;
                    dbConnection.Open();

                    var dbCommand = dbProviderFactory.CreateCommand();
                    dbCommand.Connection = dbConnection;
                    dbCommand.CommandText = "DELETE FROM Contacts WHERE ContactId = @ContactId";

                    dbCommand.Parameters.Add(CreateParameter("@ContactId", contactId, DbType.Int32));

                    if (dbCommand.ExecuteNonQuery() > 0)
                    {
                        STATUS = "Contact deleted successfully.";
                    }
                    else
                    {
                        throw new Exception("An error occurred.");
                    }

                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    STATUS = ex.Message;
                }
            }

            base.DeleteContactById(contactId);
        }
    }
}
