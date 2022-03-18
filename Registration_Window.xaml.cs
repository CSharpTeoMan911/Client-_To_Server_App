using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client__To_Server_App
{
    /// <summary>
    /// Interaction logic for Registration_Window.xaml
    /// </summary>
    public partial class Registration_Window : Window
    {
        private string Id_Buffer;

        private string Password_Buffer;

        private bool Window_Closing;

        private System.Timers.Timer AnimationTimer;

        private byte OnOff;

        private bool Network_Settings_Panel_Expanded;

        private string TextBox1_Buffer;

        private string TextBox2_Buffer;

        private string TextBox3_Buffer;

        private string TextBox4_Buffer;

        private string Port_TextBox_Buffer;

        public Registration_Window()
        {
            InitializeComponent();
        }



        private void AnimationTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch (this == null)
                                        {
                                            case false:

                                                switch (Network_Settings_Panel_Expanded)
                                                {
                                                    case true:
                                                        switch (Network_Settings_Panel.ActualHeight < Height_Reference.ActualHeight * 2)
                                                        {
                                                            case true:
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                Network_Settings_Panel.Height++;
                                                                break;
                                                        }
                                                        break;

                                                    case false:
                                                        Network_Settings_Panel.Height = 0;

                                                        App.Ip = First_Ip_TextBox.Text + "." + Second_Ip_TextBox.Text + "." + Third_Ip_TextBox.Text + "." + Fourth_Ip_TextBox.Text;
                                                        App.Port = Port_TextBox.Text;
                                                        break;
                                                }
                                                break;
                                        }
                                    });
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Minimise_Button_Clicked(object sender, RoutedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:

                                            this.WindowState = WindowState.Minimized;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Close_Button_Clicked(object sender, RoutedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:

                                            this.Close();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void ID_Text_Changed(object sender, TextChangedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:
                                            switch (Id_TextBox.Text.Length > 20)
                                            {
                                                case true:
                                                    Id_TextBox.Text = Id_Buffer;
                                                    break;

                                                case false:
                                                    try
                                                    {
                                                        Convert.ToDouble(Id_TextBox.Text);
                                                        Id_Buffer = Id_TextBox.Text;
                                                    }
                                                    catch
                                                    {
                                                        Id_TextBox.Text = Id_Buffer;
                                                    }
                                                    break;
                                            }

                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Passoword_Text_Changed(object sender, RoutedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:
                                            switch (Id_TextBox.Text.Length > 20)
                                            {
                                                case true:
                                                    Password_TextBox.Password = Password_Buffer;
                                                    break;

                                                case false:
                                                    Password_Buffer = Password_TextBox.Password;
                                                    break;
                                            }

                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

       

        private void Log_In(object sender, RoutedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:

                                            Log_In_Window log_In_Window = new Log_In_Window();
                                            log_In_Window.Show();

                                            this.Close();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Move_The_Window(object sender, MouseButtonEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:

                                            this.DragMove();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Registration_Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window_Closing = true;
        }

        private void User_Registration(object sender, RoutedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:

                                            var ParallelProcessing = new System.Threading.Thread(async () =>
                                            {
                                                string Id = Id_Buffer;
                                                string Password = Password_Buffer;

                                                Server_Connection<string, string, string, string, string, string> server_connection = new Server_Connection<string, string, string, string, string, string>();
                                                var response = await server_connection.Register(Id, Password);

                                                switch (response)
                                                {
                                                    case true:
                                                        Server_Connection<string, string, string, string, string, string> log_in_server_connection = new Server_Connection<string, string, string, string, string, string>();
                                                        var log_in_response = await server_connection.Log_In(Id, Password);

                                                        switch(log_in_response)
                                                        {
                                                            case true:

                                                                Application.Current.Dispatcher.Invoke(() =>
                                                                {
                                                                    MainWindow mainWindow = new MainWindow(Id, Password);
                                                                    mainWindow.Show();
                                                                    Application.Current.MainWindow = mainWindow;
                                                                    this.Close();
                                                                });
                                                                break;

                                                            case false:
                                                                break;
                                                        }
                                                        
                                                        break;

                                                    case false:
                                                        break;
                                                }
                                            });
                                            ParallelProcessing.SetApartmentState(System.Threading.ApartmentState.STA);
                                            ParallelProcessing.Priority = System.Threading.ThreadPriority.AboveNormal;
                                            ParallelProcessing.IsBackground = true;
                                            ParallelProcessing.Start();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Expand_Network_Settings(object sender, RoutedEventArgs e)
        {
            switch (Window_Closing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (this == null)
                                    {
                                        case false:

                                            OnOff++;

                                            switch (OnOff)
                                            {
                                                case 1:
                                                    Network_Settings_Panel_Expanded = true;
                                                    break;

                                                case 2:
                                                    Network_Settings_Panel_Expanded = false;
                                                    OnOff = 0;
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        private void Registration_Window_Opened(object sender, RoutedEventArgs e)
        {
            int Count = 0;

            for (int Index = 0; Index <= App.Ip.Length - 1; Index++)
            {
                switch (App.Ip[Index] == '.')
                {
                    case true:
                        Count++;
                        break;

                    case false:
                        switch (Count)
                        {
                            case 0:
                                First_Ip_TextBox.Text += App.Ip[Index];
                                break;

                            case 1:
                                Second_Ip_TextBox.Text += App.Ip[Index];
                                break;

                            case 2:
                                Third_Ip_TextBox.Text += App.Ip[Index];
                                break;

                            case 3:
                                Fourth_Ip_TextBox.Text += App.Ip[Index];
                                break;
                        }
                        break;
                }
            }

            Port_TextBox.Text = App.Port.ToString();

            AnimationTimer = new System.Timers.Timer();
            AnimationTimer.Elapsed += AnimationTimer_Elapsed;
            AnimationTimer.Interval = 10;
            AnimationTimer.Start();
        }


        private void First_Ip_Textbox_Text_Changed(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox)sender;

            switch (textbox.Text.Length > 3)
            {
                case true:
                    textbox.Text = TextBox1_Buffer;
                    break;

                case false:
                    try
                    {
                        Convert.ToDouble(textbox.Text);
                        TextBox1_Buffer = textbox.Text;
                    }
                    catch
                    {
                        textbox.Text = TextBox1_Buffer;
                    }
                    break;
            }
        }

        private void Second_Ip_Textbox_Text_Changed(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox)sender;

            switch (textbox.Text.Length > 3)
            {
                case true:
                    textbox.Text = TextBox2_Buffer;
                    break;

                case false:
                    try
                    {
                        Convert.ToDouble(textbox.Text);
                        TextBox2_Buffer = textbox.Text;
                    }
                    catch
                    {
                        textbox.Text = TextBox2_Buffer;
                    }
                    break;
            }
        }

        private void Third_Ip_Textbox_Text_Changed(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox)sender;

            switch (textbox.Text.Length > 3)
            {
                case true:
                    textbox.Text = TextBox3_Buffer;
                    break;

                case false:
                    try
                    {
                        Convert.ToDouble(textbox.Text);
                        TextBox3_Buffer = textbox.Text;
                    }
                    catch
                    {
                        textbox.Text = TextBox3_Buffer;
                    }
                    break;
            }
        }

        private void Fourth_Ip_Textbox_Text_Changed(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox)sender;

            switch (textbox.Text.Length > 3)
            {
                case true:
                    textbox.Text = TextBox4_Buffer;
                    break;

                case false:
                    try
                    {
                        Convert.ToDouble(textbox.Text);
                        TextBox4_Buffer = textbox.Text;
                    }
                    catch
                    {
                        textbox.Text = TextBox4_Buffer;
                    }
                    break;
            }
        }

        private void Port_Textbox_Text_Changed(object sender, TextChangedEventArgs e)
        {
            var textbox = (TextBox)sender;

            switch (textbox.Text.Length > 5)
            {
                case true:
                    textbox.Text = Port_TextBox_Buffer;
                    break;

                case false:
                    try
                    {
                        Convert.ToDouble(textbox.Text);

                        switch (Convert.ToDouble(textbox.Text) <= 65535)
                        {
                            case true:
                                Port_TextBox_Buffer = textbox.Text;
                                break;

                            case false:
                                textbox.Text = Port_TextBox_Buffer;
                                break;
                        }

                    }
                    catch
                    {
                        textbox.Text = Port_TextBox_Buffer;
                    }
                    break;
            }
        }
    }
}
