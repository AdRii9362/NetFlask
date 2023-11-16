using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Text.Json;


#region Creation de la connexion

//connexion string
string connectionString = @"Data Source=GOS-VDI206\TFTIC;Initial Catalog=NetFlask;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;";

DbConnection connection = new SqlConnection(connectionString);//objet connexion


try
{
	connection.Open();
    Console.WriteLine("OUVERTURE DE LA CONNECTION VERS SQL SERVER");
    Console.WriteLine($"ETAT DE LA CONNECTION: {connection.State}");
    Console.WriteLine();

 //   //1er test : insérer une donnée via une COMMAND
 //   DbCommand command = connection.CreateCommand();

	////requête test 
	//string Genre = Console.ReadLine();// ')Delete From Genre;--
	//string query = "Insert into Genre OUTPUT inserted.IdGenre Values (@MonGenre)";

	////Ajouter les paramètres
	//DbParameter dbParameter = command.CreateParameter();
	//dbParameter.Value = Genre;
	//dbParameter.ParameterName = "MonGenre";
	//dbParameter.DbType = System.Data.DbType.String;
	//dbParameter.Size = 150;

	////Ajouter la query dans la commande
	//command.CommandText = query;
	//command.CommandType = System.Data.CommandType.Text;

	////Ajouter les paramètres Commande
	//command.Parameters.Add(dbParameter);

	////J execute

	////Comme c est un INSERT => ExecuteNonQuery ou ExecuteScalar
	//int lenouvelId = (int)command.ExecuteScalar();
 //   Console.WriteLine($"id du genre : {lenouvelId}");

    //je ferme la connexion
    Console.WriteLine("FERMETURE DE LA CONNECTION");
    connection.Close();
    Console.WriteLine($"ETAT DE LA CONNECTION: {connection.State}");
}
catch (Exception ex)
{

	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine(ex.Message);
	Console.ResetColor();

}


using (SqlConnection c = new SqlConnection(connectionString))
{
    using (SqlCommand cmd = c.CreateCommand())
    {
        //COMMANDE SQL
        cmd.CommandText = "SELECT IdGenre(2) FROM Genre;";
        cmd.CommandType = CommandType.Text;

        //OUVRIR LA CONNEXION VERS LA DB
        c.Open();

        //EXECUTION DE LA CMD SQL   
        int idGenre = (int)cmd.ExecuteScalar();

        Console.WriteLine($"id:  {idGenre} ");
    }
    //FERMER LA CONNEXION VERS LA DB AUTOMATIQUEMENT QUAND ON SORT DU DB
}


#endregion