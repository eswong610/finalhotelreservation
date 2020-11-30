using FinalHotelReservation.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHotelReservation
{
    public partial class Form1 : Form
    {
        private Entity.HotelReservationEntities dbContext = new Entity.HotelReservationEntities();
        public Form1()
        {
            //this.Context = dbContext;
            InitializeComponent();
            MenuNavigate.SelectedIndexChanged += new EventHandler(MenuNavigate_SelectedIndexChanged);
        }

        private void MenuNavigate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MenuNavigate.SelectedTab.Text == "All Guests")
            {
                InitializeDataGridView();
                //MessageBox.Show("all guests");
            }
            else if (MenuNavigate.SelectedTab.Text == "New Booking")
            {
                //MessageBox.Show("new booking");
                InitializeAvailableRoomsGridView();
                InitializeSelectedRoomOnBooking();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string DBString = "Data Source=localhost;Initial Catalog=HotelReservation;Integrated Security=True;MultipleActiveResultSets=true";
            DB.ResetSchema();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewGuestBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string firstName = newGuestFirstName.Text;
                string lastName = newGuestLastName.Text;
                string birthDate = dobDatePicker.Text;
                string phoneNumber = newGuestTelephone.Text;
                string email = newGuestEmail.Text;
                string address = newGuestAddress.Text;
                string city = newGuestCity.Text;
                string country = newGuestCountry.Text;
                DB.CreateUser(email, firstName, lastName, birthDate, address, city, country);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                MessageBox.Show(err.Message);
            }
            //    Entity.Guest dbGuest = null;
            //    //search for existing email/phone number
            //    //if (dbGuest == null)
            //    //{
            //    dbGuest = new Entity.Guest
            //    {
            //        FirstName = newGuestFirstName.Text,
            //        LastName = newGuestLastName.Text,
            //        PhoneNumber = newGuestTelephone.Text,
            //        Email = newGuestEmail.Text,
            //        Address = newGuestAddress.Text,
            //        City = newGuestCity.Text,
            //        Country = newGuestCountry.Text
            //    };

            //    bool isEmailDuplicate = dbContext.Guests.Any(x => x.Email == dbGuest.Email || x.PhoneNumber == dbGuest.PhoneNumber);
            //    bool isPhoneDuplicate = dbContext.Guests.Any(x => x.PhoneNumber == dbGuest.PhoneNumber);
            //    if (isPhoneDuplicate)
            //    {
            //        MessageBox.Show("The phone number already exists");
            //        goto Error;
            //    }
            //    else if (isEmailDuplicate)
            //    {
            //        MessageBox.Show("The email already exists; ");
            //        goto Error;
            //    }

            //    if (dbGuest.FirstName.Length == 0 || dbGuest.LastName.Length == 0 || dbGuest.Address.Length == 0 || dbGuest.City.Length ==0 || dbGuest.Country.Length == 0)
            //    {
            //        MessageBox.Show("You need more info");
            //        goto Error;

            //    }
            //    else
            //    {
            //        dbContext.Guests.Add(dbGuest);
            //        dbContext.SaveChanges();
            //        MessageBox.Show("New Guest Successfully Added to Database");
            //        newGuestFirstName.Text = newGuestLastName.Text = newGuestTelephone.Text = newGuestEmail.Text = newGuestAddress.Text = newGuestCity.Text = newGuestCountry.Text = "";
            //    }

            //Error:
            //    MessageBox.Show("Failed to Add");

        }

        private void InitializeDataGridView()
        {
            try
            {
                // Set up the DataGridView.
                AllGuestsDataView.Dock = DockStyle.Fill;

                // Automatically generate the DataGridView columns.
                AllGuestsDataView.AutoGenerateColumns = true;

                // Set up the data source.
                //bindingSource1.DataSource = dbContext.Guests.ToList();
                //AllGuestsDataView.DataSource = bindingSource1;

                DataTable dt = DB.RetreiveUser();
                AllGuestsDataView.DataSource = dt;

                // Automatically resize the visible rows.
                AllGuestsDataView.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                // Set the DataGridView control's border.
                AllGuestsDataView.BorderStyle = BorderStyle.Fixed3D;

                // Put the cells in edit mode when user enters them.
                AllGuestsDataView.EditMode = DataGridViewEditMode.EditOnEnter;
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void InitializeSelectedRoomOnBooking()
        {
            try
            {
                // Set up the data source.
                List<string> dt = DB.RetreiveRoomDescriptions();
                SelectedRoomOnBooking.DataSource = dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        private void InitializeAvailableRoomsGridView()
        {

            // Set up the DataGridView.
            AvailableRoomsGridView.Dock = DockStyle.Fill;

            // Automatically generate the DataGridView columns.
            AvailableRoomsGridView.AutoGenerateColumns = true;

            // Set up the data source.
            DataTable dt = DB.RetreiveAvailableRooms("", "", "All room types"); //takes checkInDate/checkOutDate as YYYYMMDD
            AvailableRoomsGridView.DataSource = dt;

            // Automatically resize the visible rows.
            AvailableRoomsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            AvailableRoomsGridView.BorderStyle = BorderStyle.Fixed3D;

            // Put the cells in edit mode when user enters them.
            AvailableRoomsGridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }


        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            var allGuests = dbContext.Guests;
            guestBindingSource1.DataSource = allGuests;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AllGuestsDataView.SelectedRows)
            {
                AllGuestsDataView.Rows.RemoveAt(row.Index);
            }
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AllGuestsDataView.SelectedRows)
            {
                AllGuestsDataView.Rows.RemoveAt(row.Index);
            }
        }


        private void GuestSearchBtn_Click(object sender, EventArgs e)
        {
            string guestEmail = firstNameTextBox.Text;
            string guestPhone = phoneNumberTextBox.Text;

            Entity.Guest dbGuest = dbContext.Guests.Where(x => x.Email == guestEmail && x.PhoneNumber == guestPhone).FirstOrDefault();
            MessageBox.Show(dbGuest.FirstName);
        }

        private void newGuestLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dobDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void RefreshGuestsGrid(object sender, EventArgs e)
        {
            //DataTable dt = DB.RetreiveUser();
            //AllGuestsDataView.DataSource = dt;
            //or
            //List<string> row = DB.RetreiveUserAsList("joe@smith.com");
            //foreach (var column in row)
            //{
            //    Console.WriteLine(column);
            //}

            DB.RetreiveRoomDescriptions();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void AvailableRoomSelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = AvailableRoomsGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var row = AvailableRoomsGridView.SelectedRows[0];
            if (row == null) return;
            UpdateRoomSelectedOnBookingScreen(row);
        }

        private void UpdateRoomSelectedOnBookingScreen(DataGridViewRow row)
        {
            Console.WriteLine(row);
            SelectedRoomOnBooking.Text = AvailableRoomsGridView.SelectedCells[1].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void checkInBtn_Click(object sender, EventArgs e)
        {
            //update with selected item booking id
            DB.UpdateBooking(9, "CheckIn");
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            //update with selected item booking id
            DB.UpdateBooking(9, "CheckOut");
        }

        private void SelectedRoomOnBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = SelectedRoomOnBooking.SelectedItem.ToString();
            Console.WriteLine(selection);
            //default All room types

            DataTable dt = DB.RetreiveAvailableRooms("", "", selection); //takes checkInDate/checkOutDate as YYYYMMDD
            AvailableRoomsGridView.DataSource = dt;
        }
    }
}
