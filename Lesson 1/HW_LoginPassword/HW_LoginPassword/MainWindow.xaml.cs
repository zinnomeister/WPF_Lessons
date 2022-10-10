﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows;

namespace HW_LoginPassword
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<User> allUsers = new List<User>();
        static char splitSeparator = '|';
        static string filePath = @"C:\Users\zinno\OneDrive\Разработка\Storage\ListForLogin.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckData(object sender, RoutedEventArgs e)
        {
            string InputedLogin = InputLogin.Text;
            string InputedPassword = InputPassword.Text;

            ExtractFromFile();

            foreach (var user in allUsers)
            {
                if (InputedLogin == user.Name && InputedPassword == user.Password)
                {
                    SuccessfullyLogin();
                    return;
                }

                FailedLogin();
            }

        }

        static void ExtractFromFile()
        {
            List<string> allUsersFromFile = File.ReadAllLines(filePath).ToList();
            foreach (string userString in allUsersFromFile)
            {
                User userFromFile = new User();
                string[] userData = userString.Split(splitSeparator);
                userFromFile.Name = userData[0];
                userFromFile.Password = userData[1];
                allUsers.Add(userFromFile);
            }
            Console.WriteLine();
        }

        public void SuccessfullyLogin()
        {
            InputPassword.Text = "";

            UiResultText.Text = "Successfully Login!";

            SoundPlayer lion1 = new SoundPlayer(HW_LoginPassword.Resources.Resource1.lionsvoice1);
            lion1.Play();
        }

        public void FailedLogin()
        {
            InputLogin.Text = "";
            InputPassword.Text = "";

            UiResultText.Text = "Login Failed! Try again!";

            SoundPlayer lion2 = new SoundPlayer(HW_LoginPassword.Resources.Resource1.lionsvoice2);
            lion2.Play();
        }
    }

}
