using MySql.Data.MySqlClient;

//Honestly stolen but who dafuq cares as long as it works
public class DatabaseHelper
{
    private const string connectionString = "Server=localhost;Database=qwertyballsdb;Uid=root;Pwd=[Removed for Potential Privacy Issues];";

    public static MySqlConnection GetConnection()
    {
        try
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error connecting to the database: " + ex.Message);
            throw;
        }
    }

    public static int ExecuteQuery(string query)
    {
        try
        {
            using (var connection = GetConnection())
            {
                var command = new MySqlCommand(query, connection);
                return command.ExecuteNonQuery();
            }
        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"Database Error: {ex.Message}");
            return -1;
        }
    }

    public static object ExecuteScalarQuery(string query)
    {
        object result = null;

        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    result = command.ExecuteScalar();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error executing scalar query: {ex.Message}");
        }

        return result;
    }

    public static MySqlDataReader ExecuteReader(string query)
    {
        try
        {
            var connection = GetConnection();
            var command = new MySqlCommand(query, connection);
            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Database Error: " + ex.Message);
            throw;
        }
    }

    public static bool IsCharacterNameTaken(string characterName)
    {
        string query = "SELECT COUNT(*) FROM characters WHERE character_name = @characterName";
        using (var connection = GetConnection())
        {
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@characterName", characterName);

            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }
    }

    public static string EscapeApostrophes(string input)
    {
        return input.Replace("'", "''");
    }

    public static void UpdateFacePaintStatus(int characterId, bool facePaint)
    {
        string query = "UPDATE characters SET face_paint = @facePaint WHERE id = @characterId";
        using (var connection = GetConnection())
        {
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@facePaint", facePaint ? 1 : 0);
            command.Parameters.AddWithValue("@characterId", characterId);

            command.ExecuteNonQuery();
        }
    }
}