using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalHotelReservation
{
    class DatabaseInterface
    {
        private static string DB_URL = "C:\\Users\\zeta two\\Desktop\\BCIT C Sharp\\Lecture 11\\Week11_DB\\Week11_DB\\db.mdf";
        private static string connection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={DB_URL};Integrated Security=True;Connect Timeout=30";

        static SqlConnection OpenDB()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            return con;
        }

        public static void ResetSchema()
        {
            SqlConnection con = OpenDB();
            try
            {

                Console.WriteLine(con);

                SqlCommand cmd = new SqlCommand("DROP TABLE IF EXISTS booking;", con);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS promo;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS hotel_location;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS room_type;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS room;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS users;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE users(user_id INT PRIMARY KEY,email VARCHAR(255) UNIQUE NOT NULL,password_hash VARCHAR(255),first_name VARCHAR(255) NOT NULL,last_name VARCHAR(255) NOT NULL,birth_date VARCHAR(255) NOT NULL,created_at datetime default CURRENT_TIMESTAMP)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE room(room_id INT PRIMARY KEY,roomtype_id INT UNIQUE,booking_id INT UNIQUE,location_id INT UNIQUE)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE room_type(roomtype_id INT PRIMARY KEY,num_beds INT,max_occupancy INT,smoker bit,room_view bit,basic_price decimal,FOREIGN KEY(roomtype_id) REFERENCES room(roomtype_id))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE hotel_location(location_id INT PRIMARY KEY,city_name VARCHAR(255) NOT NULL,country_code VARCHAR(255) NOT NULL,location_address VARCHAR(255) NOT NULL,FOREIGN KEY(location_id) REFERENCES room(location_id))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE promo_code(promo_id INT PRIMARY KEY,promo_code VARCHAR(255) NOT NULL)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE booking(booking_id INT PRIMARY KEY,user_id int NOT NULL,room_id int NOT NULL,num_adults INT,num_children INT,checkin DateTime,checkout DateTime,FOREIGN KEY(user_id) REFERENCES users(user_id),FOREIGN KEY(room_id) REFERENCES room(room_id))";
                cmd.ExecuteNonQuery();



                Console.Write("Reset Complete.");



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();

            }
        }
    }
}
