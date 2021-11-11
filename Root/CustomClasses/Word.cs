using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Root; 

namespace Root
{
	public class Word
	{
		public string name;
		public string definition;

		public Word() { }
		
		public  Word(string wordName) 
		{
			this.name = wordName; 
		}
		
		public bool AddWord()
		{
			bool wasInserted = false; 

			bool wordExists = CheckWordExists();
			 
			if (!wordExists)
			{
				string sqlQuery = String.Format($"Insert into Word (Name, Definition) Values('{name}', '{definition}');");

				string ConnectionString = Application.StartupPath + "VocabularyTest.mdf";
				//string ConnectionString = @"F:\ITI\Database Devlopment\Project\VocabularyTest.mdf";
				//string ConnectionString = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VocabularyTest.mdf";

				SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename=" + ConnectionString + "; Integrated Security=True; Connect Timeout=30; User Instance=True");
				try
				{
					connection.Open();

					SqlCommand command = new SqlCommand(sqlQuery, connection);

					var reader = command.ExecuteReader();
					int recordsEffected = reader.RecordsAffected;

					if (recordsEffected == 0)
					{
						wasInserted = false;
					}
					else
					{
						wasInserted = true;
					}

					//Close and dispose
					command.Dispose();
					connection.Close();
					connection.Dispose();
				}
				catch (Exception ex) 
				{
					MessageBox.Show(ex.Message); 
				}

				return wasInserted;
			}
			else
				wasInserted = false;
			
			return wasInserted;
		}

		public bool CheckWordExists()
		{
			bool exists = false;

			Word result = new Word();

			string sqlQuery = String.Format("select * from Word where Name='{0}'", name);

			string ConnectionString = Application.StartupPath + "VocabularyTest.mdf";
			//string ConnectionString = @"F:\ITI\Database Devlopment\Project\VocabularyTest.mdf";
			//string ConnectionString = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VocabularyTest.mdf";

			SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename=" + ConnectionString + "; Integrated Security=True; Connect Timeout=30; User Instance=True");

			try
			{
				connection.Open();

				SqlCommand command = new SqlCommand(sqlQuery, connection);

				SqlDataReader dataReader = command.ExecuteReader();

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

		public List<Word> GetWords()
		{
			List<Word> result = new List<Word>();

			string sqlQuery = String.Format("select * from Word");

			string ConnectionString = Application.StartupPath + "VocabularyTest.mdf";
			//string ConnectionString = @"F:\ITI\Database Devlopment\Project\VocabularyTest.mdf";
			//string ConnectionString = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VocabularyTest.mdf";
			
			SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename=" + ConnectionString + "; Integrated Security=True; Connect Timeout=30; User Instance=True");
			try
			{
				connection.Open();

				SqlCommand command = new SqlCommand(sqlQuery, connection);

				SqlDataReader dataReader = command.ExecuteReader();

				Word word = null;

				if (dataReader.HasRows)
				{
					while (dataReader.Read())
					{
						word = new Word();
						word.name = dataReader["Name"].ToString();
						word.definition = dataReader["Definition"].ToString();
						result.Add(word);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message); 
			}

			return result;
		}

		public void DisplayWords() 
		{
			List<Word> words = GetWords();
			string allWords = "";
			foreach (Word w in words) 
			{
				allWords += w.name + "\n";
			}
			MessageBox.Show(allWords);
		}

		public bool RemoveWord() 
		{
			bool result = false;

			//Create the SQL Query for deleting an article
			string sqlQuery = String.Format("delete from Word where name = '{0}'", name);

			string ConnectionString = Application.StartupPath + "VocabularyTest.mdf";

			//Create and open a connection to SQL Server 
			SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename=" + ConnectionString + "; Integrated Security=True; Connect Timeout=30; User Instance=True");
			connection.Open();

			//Create a Command object
			SqlCommand command = new SqlCommand(sqlQuery, connection);

			// Execute the command
			int rowsDeletedCount = command.ExecuteNonQuery();
			if (rowsDeletedCount != 0)
				result = true;
			// Close and dispose
			command.Dispose();
			connection.Close();
			connection.Dispose();


			return result;
		}

	}
	
}
