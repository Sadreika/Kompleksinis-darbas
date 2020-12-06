using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StarPeru
{
    public class Program
    {
        private static string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=FlightsDatabase;Integrated Security=True";
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();
            List<Combinations> flights = crawler.Start("HUU|LIM|2020|12|10|2020|12|17|E|R");
            FillDatabase(flights);
        }
        public static void FillDatabase(List<Combinations> combinations)
        {
            SqlConnection con = new SqlConnection(connectionString);
            foreach(Combinations combination in combinations)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = con;
                con.Open();
                command.Parameters.AddWithValue("@OriginOutbound", combination.Outbound.Origin);
                command.Parameters.AddWithValue("@DestinationOutbound", combination.Outbound.Destination);
                command.Parameters.AddWithValue("@ConnectionOutbound", "null");
                command.Parameters.AddWithValue("@PriceOutbound", combination.Outbound.Price);
                command.Parameters.AddWithValue("@DepartureTimeOutbound", combination.Outbound.DepartureTime);
                command.Parameters.AddWithValue("@ArrivalTimeOutbound", combination.Outbound.ArrivalTime);
                command.Parameters.AddWithValue("@OriginInbound", combination.Inbound.Origin);
                command.Parameters.AddWithValue("@DestinationInbound", combination.Inbound.Destination);
                command.Parameters.AddWithValue("@ConnectionInbound", "null");
                command.Parameters.AddWithValue("@PriceInbound", combination.Inbound.Price);
                command.Parameters.AddWithValue("@DepartureTimeInbound", combination.Inbound.DepartureTime);
                command.Parameters.AddWithValue("@ArrivalTimeInbound", combination.Inbound.ArrivalTime);
                command.Parameters.AddWithValue("@Class", "E");
                command.Parameters.AddWithValue("@Airline", "StarPeru");

                command.CommandText = "INSERT [FlightsDatabase].[dbo].[StarPeru] (OriginOutbound, DestinationOutbound, ConnectionOutbound," +
               "PriceOutbound, DepartureTimeOutbound, ArrivalTimeOutbound," +
               "OriginInbound, DestinationInbound, ConnectionInbound," +
               "PriceInbound, DepartureTimeInbound, ArrivalTimeInbound," +
               "Class, Airline)" +
               "VALUES (@OriginOutbound, @DestinationOutbound, @ConnectionOutbound, @PriceOutbound, @DepartureTimeOutbound," +
               "@ArrivalTimeOutbound, @OriginInbound, @DestinationInbound, @ConnectionInbound, @PriceInbound, @DepartureTimeInbound," +
               "@ArrivalTimeInbound, @Class, @Airline)";

                command.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
