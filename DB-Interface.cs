using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHotelReservation
{
    class DB
    {
        private static string DB_URL = "C:\\Users\\zeta two\\Desktop\\BCIT C Sharp\\Lecture 11\\Week11_DB\\Week11_DB\\db.mdf";
        //private static string connection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={DB_URL};Integrated Security=True;Connect Timeout=30";
        //private static string connection = "Data Source=localhost;Initial Catalog=HotelReservation;Integrated Security=True;MultipleActiveResultSets=true";
        private static string connection = "Data Source=localhost;Initial Catalog=Hotel;Integrated Security=True;MultipleActiveResultSets=true";

        public static SqlConnection Open()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            return con;
        }

        public static void ResetSchema()
        {
            SqlConnection con = Open();
            try
            {
                Console.WriteLine(con);

                SqlCommand cmd = new SqlCommand("DROP TABLE IF EXISTS booking;", con);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS promo_code;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS room;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS hotel_location;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS room_type;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS users;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE users(user_id INT IDENTITY PRIMARY KEY,email VARCHAR(255) UNIQUE NOT NULL,first_name VARCHAR(255) NOT NULL,last_name VARCHAR(255) NOT NULL,birth_date VARCHAR(255) NOT NULL,address VARCHAR(255),city VARCHAR(255),country VARCHAR(255))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE room_type(roomtype_id INT NOT NULL PRIMARY KEY, description VARCHAR(255), num_beds INT,max_occupancy INT,smoker bit,room_view bit,basic_price decimal)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE hotel_location(location_id INT NOT NULL PRIMARY KEY, city_name VARCHAR(255) NOT NULL,country VARCHAR(255) NOT NULL,location_address VARCHAR(255) NOT NULL)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE room(room_id INT IDENTITY PRIMARY KEY, roomtype_id INT, location_id INT, FOREIGN KEY(roomtype_id) REFERENCES room_type(roomtype_id), FOREIGN KEY(location_id) REFERENCES hotel_location(location_id))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE promo_code(promo_id INT IDENTITY PRIMARY KEY,promo_code VARCHAR(255) NOT NULL)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE booking(booking_id INT IDENTITY PRIMARY KEY,user_id int NOT NULL,room_id int NOT NULL,num_adults INT,num_children INT,check_in_date Date,check_out_date Date,FOREIGN KEY(user_id) REFERENCES users(user_id),FOREIGN KEY(room_id) REFERENCES room(room_id))";
                cmd.ExecuteNonQuery();

                //users
                cmd.CommandText = "INSERT INTO users (email, first_name, last_name, birth_date, address, city, country) VALUES (\'joe@smith.com\', \'joe\', \'smith\', \'November, 11, 1990\', \'100 sharp crescent\', \'seattle\', \'united states\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO users (email, first_name, last_name, birth_date, address, city, country) VALUES (\'alice@wong.com\', \'alice\', \'wong\', \'July, 7, 1992\', \'100 zombie valley\', \'san francisco\', \'united states\')";
                cmd.ExecuteNonQuery();

                //roomtypes
                cmd.CommandText = "INSERT INTO room_type (roomtype_id, description, num_beds, max_occupancy, smoker, room_view, basic_price) VALUES (1, \'studio no view non-smoker\', 1, 2, 0, 0, 60)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room_type (roomtype_id, description, num_beds, max_occupancy, smoker, room_view, basic_price) VALUES (2, \'studio with view non-smoker\', 1, 2, 0, 1, 75)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room_type (roomtype_id, description, num_beds, max_occupancy, smoker, room_view, basic_price) VALUES (3, \'one bedroom no view non-smoker\', 2, 4, 0, 0, 100)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room_type (roomtype_id, description, num_beds, max_occupancy, smoker, room_view, basic_price) VALUES (4, \'one bedroom with view non-smoker\', 2, 4, 0, 1, 115)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room_type (roomtype_id, description, num_beds, max_occupancy, smoker, room_view, basic_price) VALUES (5, \'two bedroom with view non-smoker\', 3, 6, 0, 1, 150)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room_type (roomtype_id, description, num_beds, max_occupancy, smoker, room_view, basic_price) VALUES (6, \'deluxe two bedroom with view non-smoker\', 3, 6, 0, 1, 200)";
                cmd.ExecuteNonQuery();

                //location
                cmd.CommandText = "INSERT INTO hotel_location (location_id, city_name, country, location_address) VALUES (1, \'vancouver\', \'canada\', \'888 waterfront st.\')";
                cmd.ExecuteNonQuery();

                //rooms
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (1, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (1, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (1, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (1, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (2, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (2, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (2, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (2, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (3, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (3, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (3, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (3, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (4, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (4, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (4, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (4, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (5, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (5, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (6, 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO room (roomtype_id, location_id) VALUES (6, 1)";
                cmd.ExecuteNonQuery();

                //bookings (booking_id INT IDENTITY PRIMARY KEY,user_id int NOT NULL,room_id int NOT NULL,num_adults INT,num_children INT,check_in_date Date,check_out_date Date)
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 1, 2, 0, \'20201201\', \'20201215\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (2, 2, 2, 0, \'20201201\', \'20201215\')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 1, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                //and initialize every room with a booking for querying
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 3, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 4, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 5, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 6, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 7, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 8, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 9, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 10, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 11, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 12, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 13, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 14, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 15, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 16, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 17, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 18, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 19, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO booking (user_id, room_id, num_adults, num_children, check_in_date, check_out_date) VALUES (1, 20, 2, 0, \'20200101\', \'20200101\')";
                cmd.ExecuteNonQuery();


                Console.WriteLine("Reset Complete.");
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



        public static void CreateUser(string email, string firstName, string lastName, string birthDate, string address, string city, string country)
        {
            var con = Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO users values(@email, @first_name, @last_name, @birth_date, @address, @city, @country)", con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@birth_date", birthDate);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@country", country);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        private static void ReadSingleRow(IDataRecord reader)
        {
            //Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
            //var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
            //return (String.Format("{0}, {1}", reader[0], reader[1]));
        }


        public static DataTable RetreiveUser()
        {
            var con = Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM users", con);
                
                //SqlDataReader reader = cmd.ExecuteReader();

                //while (reader.Read())
                //{
                //    Console.WriteLine(reader);
                //    ReadSingleRow((IDataRecord)reader);

                //    //Console.WriteLine(String.Format("{0}, {1}", reader.GetInt32(0), reader.GetString(1)));
                //}

                //reader.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable RetreiveUser(int userID)
        {
            var con = Open();
            try
            {
                SqlCommand cmd;
                if (userID < 0)
                {
                    throw new Exception("userID must be greater than 0.");
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM users WHERE user_id=@user_id", con);
                    cmd.Parameters.AddWithValue("@user_id", userID);
                }

                //SqlDataReader reader = cmd.ExecuteReader();

                //while (reader.Read())
                //{
                //    Console.WriteLine(reader);
                //    ReadSingleRow((IDataRecord)reader);

                //    //straight from reader
                //    //Console.WriteLine(String.Format("{0}, {1}", reader.GetInt32(0), reader.GetString(1)));
                //}

                //reader.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            finally
            {
                con.Close();
            }
        }


        public static DataTable RetreiveAvailableRooms(string checkInDate, string checkOutDate)
        {
            var con = Open();
            try
            {
                SqlCommand cmd;
                if (checkInDate == "" || checkOutDate == "")
                {
                    cmd = new SqlCommand("SELECT room.room_id, description, num_beds, max_occupancy, smoker, room_view, basic_price, city_name, country, location_address FROM room JOIN room_type ON room.roomtype_id = room_type.roomtype_id JOIN hotel_location ON room.location_id = hotel_location.location_id", con);
                } else
                {
                    cmd = new SqlCommand("SELECT room.room_id, description, num_beds, max_occupancy, smoker, room_view, basic_price, city_name, country, location_address FROM room JOIN room_type ON room.roomtype_id = room_type.roomtype_id JOIN hotel_location ON room.location_id = hotel_location.location_id WHERE room.room_id NOT IN(SELECT room.room_id FROM room JOIN room_type ON room.roomtype_id = room_type.roomtype_id JOIN hotel_location ON room.location_id = hotel_location.location_id LEFT JOIN booking ON room.room_id = booking.room_id WHERE @checkInDate BETWEEN booking.check_in_date AND booking.check_out_date AND @checkOutDate BETWEEN booking.check_in_date AND booking.check_out_date", con);
                    cmd.Parameters.AddWithValue("@checkInDate", checkInDate);
                    cmd.Parameters.AddWithValue("@checkOutDate", checkOutDate);
                }
                

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
