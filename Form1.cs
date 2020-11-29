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
                InitializeRoomDataGridView();
                //query db for available rooms
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string DBString = "Data Source=localhost;Initial Catalog=HotelReservation;Integrated Security=True;MultipleActiveResultSets=true";
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewGuestBtn_Click(object sender, EventArgs e)
        {
            //var con = DatabaseInterface.OpenDB();
            Entity.Guest dbGuest = null;
            //search for existing email/phone number
            //if (dbGuest == null)
            //{
            dbGuest = new Entity.Guest
            {
                FirstName = newGuestFirstName.Text,
                LastName = newGuestLastName.Text,
                PhoneNumber = newGuestTelephone.Text,
                Email = newGuestEmail.Text,
                Address = newGuestAddress.Text,
                City = newGuestCity.Text,
                Country = newGuestCountry.Text
            };

            bool isEmailDuplicate = dbContext.Guests.Any(x => x.Email == dbGuest.Email || x.PhoneNumber == dbGuest.PhoneNumber);
            bool isPhoneDuplicate = dbContext.Guests.Any(x => x.PhoneNumber == dbGuest.PhoneNumber);
            if (isPhoneDuplicate)
            {
                MessageBox.Show("The phone number already exists");
                goto Error;
            }
            else if (isEmailDuplicate)
            {
                MessageBox.Show("The email already exists; ");
                goto Error;
            }

            if (dbGuest.FirstName.Length == 0 || dbGuest.LastName.Length == 0 || dbGuest.Address.Length == 0 || dbGuest.City.Length ==0 || dbGuest.Country.Length == 0)
            {
                MessageBox.Show("You need more info");
                goto Error;
                
            }
            else
            {
                dbContext.Guests.Add(dbGuest);
                dbContext.SaveChanges();
                MessageBox.Show("New Guest Successfully Added to Database");
                newGuestFirstName.Text = newGuestLastName.Text = newGuestTelephone.Text = newGuestEmail.Text = newGuestAddress.Text = newGuestCity.Text = newGuestCountry.Text = "";
            }

        Error:
            MessageBox.Show("Failed to Add");

            //con.Close();
        }

        private void InitializeDataGridView()
        {
            
                // Set up the DataGridView.
                AllGuestsDataView.Dock = DockStyle.Fill;

                // Automatically generate the DataGridView columns.
                AllGuestsDataView.AutoGenerateColumns = true;

                // Set up the data source.
                bindingSource1.DataSource = dbContext.Guests.ToList();
                AllGuestsDataView.DataSource = bindingSource1;

                // Automatically resize the visible rows.
                AllGuestsDataView.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                // Set the DataGridView control's border.
                AllGuestsDataView.BorderStyle = BorderStyle.Fixed3D;

                // Put the cells in edit mode when user enters them.
                AllGuestsDataView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void InitializeRoomDataGridView()
        {
          
            // Set up the DataGridView.
            availableRoomsDataGridView.Dock = DockStyle.Fill;

            // Automatically generate the DataGridView columns.
            availableRoomsDataGridView.AutoGenerateColumns = true;

            var locations = dbContext.Locations;

            // Set up the data source.
            roomBindingSource.DataSource = dbContext.Rooms.Where(x => x.BookingId == null).ToList(); // available rooms
                
            availableRoomsDataGridView.DataSource = roomBindingSource;

            // Automatically resize the visible rows.
            availableRoomsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            availableRoomsDataGridView.BorderStyle = BorderStyle.Fixed3D;

            // Put the cells in edit mode when user enters them.
            availableRoomsDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
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

            try
            {
                dbContext.SaveChanges();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void GuestSearchBtn_Click(object sender, EventArgs e)
        {
            string guestEmail = emailTextBox.Text;
            string guestPhone = phoneNumberTextBox.Text;

            var dbGuest = dbContext.Guests.Where(x => x.Email == guestEmail && x.PhoneNumber == guestPhone).ToList();


            GuestSearchResults.DataSource = dbGuest;
            GuestSearchResults.DisplayMember = "FirstName";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createBookingBtn_Click(object sender, EventArgs e)
        {
            var selectedRooms = availableRoomsDataGridView.SelectedRows;
            var selectedGuest = GuestSearchResults.SelectedItem;
            MessageBox.Show(selectedGuest.ToString() + selectedRooms.ToString());
        }
    }
}
