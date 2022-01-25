﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace LoginScreen
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();

        }

        // Global variables
        string validUsername = "admin";  // Hard coded valid username
        string validPassword = "12345";  // Hard coded valid password
        int failedAttempts = 0;          // Counter to keep track of failed login attempts
        DateTime lockTime;               // DateTime variable to hold time when login is available again.

        private void uxSubmitBtn_Click(object sender, EventArgs e)
        {
            //try catch to check username and password
            try
            {
                string username = uxUsernameTextbox.Text;
                string password = uxPasswordTextbox.Text;

                // Check if the username exists in our records first in case of wrong password/failed attempt
                // (hardcoded value of "admin" is only available username for now)
                if (username == validUsername)
                {
                    if (failedAttempts == 3)
                    {
                        // Compares lockTime with current time. If true, account is no longer locked
                        if (DateTime.Compare(lockTime, DateTime.Now) > 0)
                        {
                            //lockTime = DateTime.Now.AddSeconds(30);
                            MessageBox.Show("Account is locked. Please try again later.");
                            return;
                        }
                        else
                        {
                            // Continue with password. NEED TO FIX
                            MessageBox.Show("Login confirmed.");
                        }
                    }
                    // Check if the password matches with the username in our records
                    if (password == validPassword)
                    {
                        // Reset failedAttempts to 0 & lockTime to null
                        failedAttempts = 0;

                        // On success, load main form/display it and close the login form
                        MainFrm frmMain = new MainFrm();
                        frmMain.Show();
                        this.Close();
                    }
                    // Password is not valid
                    else
                    {
                        // Failed third attempt. Lock the account for
                        if (failedAttempts == 3)
                        {
                            failedAttempts++;
                            MessageBox.Show("Invalid login attempt. Account has been locked for 30 seconds.");

                            // Record time 30 seconds into the future for later calculations
                            lockTime = DateTime.Now.AddSeconds(30);
                        }
                        else if (failedAttempts == 2)
                        {
                            failedAttempts++;
                            MessageBox.Show("Maximum attempts reached. Account has been locked for 30 seconds.");

                            // Record time 30 seconds into the future for later calculations
                            lockTime = DateTime.Now.AddSeconds(30);
                        }
                        else
                        {
                            failedAttempts++;
                            MessageBox.Show("Invalid login attempt. Please try again.");
                        }

                    }



                    /**
                    else
                    {
                        // Check if the password matches with the username in our records
                        if (password == validPassword)
                        {
                            // Reset failedAttempts to 0 & lockTime to null
                            failedAttempts = 0;

                            // On success, load main form/display it and close the login form
                            MainFrm frmMain = new MainFrm();
                            frmMain.Show();
                            this.Close();
                        }
                        // Password is not valid
                        else
                        {
                            // Failed third attempt. Lock the account for
                            if (failedAttempts >= 2)
                            {
                                failedAttempts++;
                                MessageBox.Show("Maximum attempts reached. Account has been locked for 30 seconds.");

                                // Record time 30 seconds into the future for later calculations
                                lockTime = DateTime.Now.AddSeconds(30);
                            }
                            else
                            {
                                failedAttempts++;
                                MessageBox.Show("Invalid Username and/or Password. Please try again.");
                            }

                        }
                    }
                    **/
                }
                // Username does not exist
                else
                {
                    MessageBox.Show("Username does not exist.");
                }


                /** if the username and password match the hardcoded values we have chosen for the time being
                if (username == validUsername && password == validPassword)
                {
                    
                    // Reset 

                    // On success, load main form/display it and close the login form
                    MainFrm frmMain = new MainFrm();
                    frmMain.Show();
                    this.Close();
                }
                else
                {
                    // On failure, increment failedAttempts

                }**/



                //SqlCommand usernameCommand = new SqlCommand("SELECT * from Security WHERE ");
                //// Take in Username and password
                //// if query results come back
                //    // 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uxExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
