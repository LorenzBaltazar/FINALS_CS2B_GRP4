﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FINALS_CS2B_GRP4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Shows the Login Form then when credentials are correct, runs the Dashboard Form
            using (frmLogin loginForm = new frmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.Yes)
                {
                    Application.Run(new frmDashboard());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}