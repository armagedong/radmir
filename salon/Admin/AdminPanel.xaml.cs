﻿using System.Windows;
using salon.Admin.AdminControl;

namespace salon;

public partial class AdminPanel : Window
{

    public AdminPanel()
    {
        InitializeComponent();
    }

    private void RedactEmployer(object sender, RoutedEventArgs e)
    {
        Content.Children.Clear();
        var employer = new RedEmploerControl();
        Content.Children.Add(employer);
    }

    public void Actions(object sender, EventArgs e)
    {
        Content.Children.Clear();
        var employer = new RedEmploerControl();
        Content.Children.Add(employer);
    }

    private void RedactService(object sender, RoutedEventArgs e)
    {
        
        Content.Children.Clear();
        var addServiceWindow = new RedSerControll();
        Content.Children.Add(addServiceWindow);
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        var messageBoxResult = MessageBox.Show("Are you sure?", "", System.Windows.MessageBoxButton.YesNo);
        if (messageBoxResult == MessageBoxResult.Yes)
        {
            Serialize.Count = 0;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
                
        }
    }

    private void ComboUsersServices_OnClick(object sender, RoutedEventArgs e)
    {
        Content.Children.Clear();
        ServisecCombo servisecCombo = new ServisecCombo();
        Content.Children.Add(servisecCombo);
    }
}