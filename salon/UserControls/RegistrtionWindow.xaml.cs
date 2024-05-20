﻿using System.Windows;

namespace salon;

public partial class RegistrtionWindow : Window
{
    

    public RegistrtionWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (Check.IsChecked == true && Log_in.Text != "" && Password.Password != "" && PasswordCheck.Password != "")
        {
            Serialize.Registration(Log_in, Password);
            Close();
        }
        else
        {
            MessageBox.Show("Заполните все необходимые данный и подтвердите условия пользования");
        }
    }

    private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}