# C# ADO.NET Contact List
Contact list application developed with Winforms, ADO.NET and C#.

This project contains different approach (Connected, Disconnected) for ADO.NET operations.

## [Download](https://github.com/yusufsefasezer/csharp-ado-contact/archive/master.zip)

## How it works
First, you must create a table with the following fields in any database system.

|   Fields      |   Type      	|
|---------------|---------------|
| ContactId     | int (auto increment) |
| FirstName     | varchar |
| LastName      | varchar |
| Email         | varchar |
| PhoneNumber   | varchar |
| Address       | varchar |
| WebAddress    | varchar |
| Notes         | varchar |

Afterwards, set properly provider and provider connection settings in `App.config`

`dataProvider = System.Data.SqlClient`

`connectionString = Data Source=.;Initial Catalog=Contact;Integrated Security=True`

# License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details

Created by [Yusuf Sezer](https://www.yusufsezer.com)
