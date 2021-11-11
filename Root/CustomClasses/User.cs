using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Root;
using System.Windows.Forms;

namespace Root
{
	public class User
	{
		public string firstName;
		public string lastName;
		public string username;
		public string password;
		public string email;
		public DateTime accountCreated;
		public bool isAdmin;

		public User() { }

		public User(string username) 
		{
			this.username = username; 
		}

		public User(string firstName, string lastName, string username, string password, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.username = username;
			this.password = password;
			this.email = email;
			this.accountCreated = DateTime.Now;
			this.isAdmin = false;
		}

		// Admin overload
		public User(string firstName, string lastName, string username, string password, string email, bool isAdmin)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.username = username;
			this.password = password;
			this.email = email;
			this.accountCreated = DateTime.Now;
			this.isAdmin = isAdmin;
		}
		
		public bool AddUser()
		{
			bool wasInserted = false;

			bool userExists =  CheckUserExists();
			//bool userExists = false; 

			if (!userExists)
			{

				// change this to user
				string sqlQuery = String.Format($"Insert into Users (firstName, lastName, username, userPassword, email, accountCreated) Values('{firstName}', '{lastName}', '{username}', '{password}', '{email}', '{accountCreated.ToString("yyyy-MM-dd")}');");

				string ConnectionString = Application.StartupPath + "VocabularyTest.mdf";
				//string ConnectionString = @"F:\ITI\Database Devlopment\Project\VocabularyTest.mdf"; 
				//string ConnectionString = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VocabularyTest.mdf";
				SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename=" + ConnectionString + "; Integrated Security=True; Connect Timeout=30; User Instance=True");
				try
				{
					connection.Open();

					//Create a Command object
					SqlCommand command = new SqlCommand(sqlQuery, connection);

					//Execute the command to SQL Server and return the newly created ID

					var reader = command.ExecuteReader();
					int recordsEffected = reader.RecordsAffected;

					if (recordsEffected == 0)
					{
						//MessageBox.Show("Error adding record");
						wasInserted = false;
					}
					else
					{
						//MessageBox.Show("Record added");
						wasInserted = true;
					}

					//Close and dispose
					command.Dispose();
					connection.Close();
					connection.Dispose();
					reader.Close();
				}
				catch (Exception ex) 
				{
					MessageBox.Show(ex.Message);
				}

				// Set return value
				return wasInserted;
			}
			else
				wasInserted = false;
			
			return wasInserted; 
		}

		public bool CheckUserExists()
		{
			bool exists = false;

			User result = new User();

			//Create the SQL Query for returning an article category based on its primary key
			string sqlQuery = String.Format("select * from Users where UserName='{0}'", username);

			string ConnectionString = Application.StartupPath + "VocabularyTest.mdf";
			//string ConnectionString = @"F:\ITI\Database Devlopment\Project\VocabularyTest.mdf";
			//string ConnectionString = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VocabularyTest.mdf";
			SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename=" + ConnectionString + "; Integrated Security=True; Connect Timeout=30; User Instance=True");
			try 
			{

				connection.Open();

				SqlCommand command = new SqlCommand(sqlQuery, connection);

				SqlDataReader dataReader = command.ExecuteReader();

				//load into the result object the returned row from the database
				if (dataReader.HasRows)
				{
					exists = true;
				}
				else
				{
					exists = false;
				}

				connection.Close(); 
				connection.Dispose();
				command.Dispose();
				dataReader.Close(); 
			}

			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message); 
			}

			return exists;
		}
	}
}
