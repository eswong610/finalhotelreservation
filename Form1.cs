﻿using FinalHotelReservation.Data;
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
                string result = DB.CreateUser(email, firstName, lastName, birthDate, address, city, country, phoneNumber);
                Console.WriteLine(result);
                MessageBox.Show(result);
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
            string email = EmailSearchTextBox.Text;
            string firstName = FirstNameSearch.Text;
            string lastName = LastNameSearch.Text;
            string phoneNumber = PhoneNumberSearch.Text;

            DataTable dt = null;

            if (email != "")
            {
                dt = DB.RetreiveUserByEmail(email);
            } else if (firstName != "" && lastName != "")
            {
                dt = DB.RetreiveUserByFirstLastName(firstName, lastName);
            } else if (phoneNumber != "")
            {
                dt = DB.RetreiveUserByPhoneNumber(phoneNumber);
            } else
            {
                MessageBox.Show("Please enter valid search criteria.");
            }
            if(dt != null)
            {
                GuestSearchResultsDataGridView.DataSource = dt;
            } else
            {
                MessageBox.Show("Please enter valid search criteria.");
            }
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void AvailableRoomSelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = AvailableRoomsGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var row = AvailableRoomsGridView.SelectedRows[0];
            if (row == null) return;
            RoomIDBox.Text = AvailableRoomsGridView.SelectedRows[0].Cells["room_id"].Value.ToString();
            SelectedRoomType.Text = AvailableRoomsGridView.SelectedRows[0].Cells["description"].Value.ToString();
            PricingCheckin.Text = CheckinDatePicker.Text;
            PricingCheckout.Text = CheckOutPicker.Text;
            UpdateRoomSelectedOnBookingScreen(row);
        }

        private void UpdateRoomSelectedOnBookingScreen(DataGridViewRow row)
        {
            Console.WriteLine(row);
            SelectedRoomOnBooking.Text = AvailableRoomsGridView.SelectedCells[1].Value.ToString();
        }

        private void SearchAvailableRoomsBtnFunction(object sender, EventArgs e)
        {
            try
            {
                string selection = SelectedRoomOnBooking.SelectedItem.ToString();
                Console.WriteLine(selection);
                //default All room types

                if (CheckinDatePicker.Text != null && CheckOutPicker.Text != null)
                {
                    string checkin = CheckinDatePicker.Value.ToString("yyyyMMdd");
                    string checkout = CheckOutPicker.Value.ToString("yyyyMMdd");
                    DataTable dt = DB.RetreiveAvailableRooms(checkin, checkout, selection); //takes checkInDate/checkOutDate as YYYYMMDD
                    AvailableRoomsGridView.DataSource = dt;
                }
                else
                {
                    DataTable dt = DB.RetreiveAvailableRooms("", "", selection); //takes checkInDate/checkOutDate as YYYYMMDD
                    AvailableRoomsGridView.DataSource = dt;
                }
            }
            catch (Exception err)
            {
                Console.Write(err);
            }
        }

        private void checkInBtn_Click(object sender, EventArgs e)
        {
            string checkinFirstName = CheckinFirstName.Text;
            string checkinLastName = CheckinLastNameTextBox.Text;
            string checkinPhoneNumber = checkInPhoneTextBox.Text;

            if (SearchBookingsGridView.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(SearchBookingsGridView.SelectedRows[0].Cells["booking_id"].Value.ToString());
                MessageBox.Show(DB.UpdateBooking(bookingId, "CheckIn"));

                DataTable dt = DB.GetFilteredBookings(checkinFirstName, checkinLastName, checkinPhoneNumber);
                SearchBookingsGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("You need to select at least one booking");
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {

            string checkinFirstName = CheckinFirstName.Text;
            string checkinLastName = CheckinLastNameTextBox.Text;
            string checkinPhoneNumber = checkInPhoneTextBox.Text;

            if (SearchBookingsGridView.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(SearchBookingsGridView.SelectedRows[0].Cells["booking_id"].Value.ToString());
                MessageBox.Show(DB.UpdateBooking(bookingId, "CheckOut"));

                DataTable dt = DB.GetFilteredBookings(checkinFirstName, checkinLastName, checkinPhoneNumber);
                SearchBookingsGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("You need to select at least one booking");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string checkinFirstName = CheckinFirstName.Text;
            string checkinLastName = CheckinLastNameTextBox.Text;
            string checkinPhoneNumber = checkInPhoneTextBox.Text;
            // Set up the DataGridView.
            SearchBookingsGridView.Dock = DockStyle.Fill;

            // Automatically generate the DataGridView columns.
            SearchBookingsGridView.AutoGenerateColumns = true;

            // Set up the data source.
            DataTable dt = DB.GetFilteredBookings(checkinFirstName, checkinLastName, checkinPhoneNumber);
            SearchBookingsGridView.DataSource = dt;

            // Automatically resize the visible rows.
            SearchBookingsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            SearchBookingsGridView.BorderStyle = BorderStyle.Fixed3D;

            // Put the cells in edit mode when user enters them.
            SearchBookingsGridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void SelectedRoomOnBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selection = SelectedRoomOnBooking.SelectedItem.ToString();
                Console.WriteLine(selection);
                //default All room types

                if (CheckinDatePicker.Text != null && CheckOutPicker.Text != null)
                {
                    string checkin = CheckinDatePicker.Value.ToString("yyyyMMdd");
                    string checkout = CheckOutPicker.Value.ToString("yyyyMMdd");
                    DataTable dt = DB.RetreiveAvailableRooms(checkin, checkout, selection); //takes checkInDate/checkOutDate as YYYYMMDD
                    AvailableRoomsGridView.DataSource = dt;
                }
                else
                {
                    DataTable dt = DB.RetreiveAvailableRooms("", "", selection); //takes checkInDate/checkOutDate as YYYYMMDD
                    AvailableRoomsGridView.DataSource = dt;
                }
            } catch (Exception err)
            {
                Console.Write(err);
            }
            
        }

        private void PromoCodeApplyDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                string promoCode = PromoCodeInput.Text;
                DataTable dt = DB.RetreiveDiscount(promoCode);
                foreach (DataRow row in dt.Rows)
                {

                    if(row["promo_id"] != null && row["discount"] != null)
                    {
                        //Console.WriteLine(row["discount"]);
                        PromoCodeOutput.Text = $"{Convert.ToInt32(row["discount"])}% Discount Applied!";
                        PromoDiscountPercentage.Text = (row["discount"]).ToString();
                    } else
                    {
                        MessageBox.Show("Sorry, invalid promo code.");
                    }
                }

            } catch (Exception err)
            {
                Console.WriteLine(err);
            }

        }

        private void createNewBooking_Click(object sender, EventArgs e)
        {
            if (AvailableRoomsGridView.SelectedRows.Count > 0 && GuestSearchResultsDataGridView.SelectedRows.Count > 0)
            {
                MenuNavigate.SelectTab(2);
            }
            else
            {
                MessageBox.Show("Please select a guest and at a room to proceed.");
            }
        }

        private void CalculatePricingButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int roomID = Int32.Parse(RoomIDBox.Text);
                string checkInDate = PricingCheckin.Value.ToString("yyyyMMdd");
                string checkOutDate = PricingCheckout.Value.ToString("yyyyMMdd");
                int numAdditionalAdults = NumAdditionalAdults.Text != "" ? Int32.Parse(NumAdditionalAdults.Text) : 0;
                int numAdditionalChildren = NumAdditionalChildren.Text != "" ? Int32.Parse(NumAdditionalChildren.Text) : 0;
                int discountPercentage = Int32.Parse(PromoDiscountPercentage.Text);

                //var priceList = new BindingList<object>();
                List<string> priceList = new List<string>();

                int totalGuests = 1 + numAdditionalAdults + numAdditionalChildren;
                int roomOccupancy = 1;
                int taxRate = 0;
                decimal roomBasePrice = -1; //sentinal value

                //get base room price
                DataTable roomDT = DB.RetreiveRoomByID(roomID);
                foreach (DataRow row in roomDT.Rows)
                {
                    roomOccupancy = Convert.ToInt32(row["max_occupancy"]);
                    roomBasePrice = Convert.ToDecimal((row["basic_price"]).ToString());
                    priceList.Add($"Base price: ${roomBasePrice.ToString()}");
                    taxRate = Convert.ToInt32(row["tax_Rate"]);
                }
                int SURCHARGE_RATE_PER_PERSON = 15; //$15 per person
                int overOccupancySurcharge = totalGuests > roomOccupancy ? (totalGuests - roomOccupancy) * SURCHARGE_RATE_PER_PERSON : 0;
                priceList.Add($"Over occupancy surcharge: ${overOccupancySurcharge.ToString()}");
                //check for season price adjustment
                int seasonAdjustmentRate = DB.RetreiveSeasonAdjustmentRate(checkInDate, checkOutDate);
                if(seasonAdjustmentRate < 0)
                {
                    seasonAdjustmentRate = 0;
                }
                priceList.Add($"Seasonal Adjustment Rate: {seasonAdjustmentRate.ToString()}%");
                priceList.Add($"Promo Discount: {discountPercentage.ToString()}%");
                priceList.Add($"Regional Tax Rate: {taxRate.ToString()}%");


                //final price = location tax * (discount * (season price * (base room price + over occupancy surchage)))
                decimal totalPrice = ((Convert.ToDecimal(taxRate)/ 100 + 1) * ((1 - Convert.ToDecimal(discountPercentage)/ 100) * ((Convert.ToDecimal(seasonAdjustmentRate)/ 100 + 1)) * (roomBasePrice + Convert.ToDecimal(overOccupancySurcharge))));
                if (totalPrice <= 0)
                {
                    throw new Exception("Invalid Price Calculation Detected.");
                }

                TotalPriceBox.Text = totalPrice.ToString();
                priceList.Add($"Total Price: ${totalPrice.ToString()}");
                
                PricingBox.Items.Clear();
                foreach (string priceLine in priceList)
                {
                    PricingBox.Items.Add(priceLine);
                }
                //var source = new BindingSource(priceList, null);
                //PricingGrid.DataSource = source;
            } catch (Exception err)
            {
                Console.WriteLine(err);
                MessageBox.Show(err.Message);
            }
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmBookingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = GuestSearchResultsDataGridView.SelectedRows[0].Cells["user_id"].Value.ToString();
                int roomID = Int32.Parse(RoomIDBox.Text);
                int numAdditionalAdults = NumAdditionalAdults.Text != "" ? Int32.Parse(NumAdditionalAdults.Text) : 0;
                int numAdditionalChildren = NumAdditionalChildren.Text != "" ? Int32.Parse(NumAdditionalChildren.Text) : 0;
                string checkInDate = PricingCheckin.Value.ToString("yyyyMMdd");
                string checkOutDate = PricingCheckout.Value.ToString("yyyyMMdd");
                decimal totalPrice = Convert.ToDecimal(TotalPriceBox.Text);

                //user_id, room_id, num_adults, num_children, check_in_date, check_out_date
                string result = DB.CreateBooking(userID, roomID, numAdditionalAdults, numAdditionalChildren, checkInDate, checkOutDate);
                Console.WriteLine(result);
                MessageBox.Show(result);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                MessageBox.Show(err.Message);
            }
        }
    }
}
