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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client__To_Server_App
{
    /// <summary>
    /// Interaction logic for GradesPage.xaml
    /// </summary>
    public partial class GradesPage : Page
    {
        string ID;
        string PASSWORD;

        private System.Timers.Timer FunctionalityTimer;

        private bool Grade_Displayer_Expanded;

        private double Initial_Fundamentals_of_Programming_Subsection_Button_Width = 400;
        private double Initial_Fundamentals_of_Programming_Subsection_Button_Height = 200;

        private double Initial_Computer_Systems_Subsection_Button_Width = 400;
        private double Initial_Computer_Systems_Subsection_Button_Height = 200;

        private double Initial_Foundation_Project_Subsection_Button_Width = 400;
        private double Initial_Foundation_Project_Subsection_Button_Height = 200;

        private double Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Width = 400;
        private double Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Height = 200;

        private double Initial_Databases_Subsection_Button_Width = 400;
        private double Initial_Databases_Subsection_Button_Height = 200;

        private double Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Width = 400;
        private double Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Height = 200;

        private double Title_TextBlock_Initial_Font_Size = 35;

        private int Initial_Go_Back_Button_Font_Size = 20;

        private int Initial_Subject_TextBlock_Font_Size = 25;

        private int Initial_Grade1_TextBlock_Font_Size = 25;

        private int Initial_Grade2_TextBlock_Font_Size = 25;

        private int Initial_Grade3_TextBlock_Font_Size = 25;

        private int Initial_Final_Grade_TextBlock_Font_Size = 25;

        private Thickness Title_StackPanel_Margin_Top = new Thickness(0, 40, 0, 0);

        private Thickness Go_Back_Button_Margin_Top = new Thickness(0, 0, 10, 0);

        private Thickness Grade1_Margin_Top = new Thickness(0, 50, 0, 0);

        private Thickness Grade2_Margin_Top = new Thickness(0, 20, 0, 0);

        private Thickness Grade3_Margin_Top = new Thickness(0, 20, 0, 0);

        private Thickness Final_Grade_Margin_Top = new Thickness(0, 20, 0, 0);

        private string Grade1 = "Grade 1: ";
        private string Grade2 = "Grade 2: ";
        private string Grade3 = "Grade 3: ";
        private string Final_Grade = "Final Grade : ";

        public GradesPage(string Id, string Password)
        {
            ID = Id;
            PASSWORD = Password;

            InitializeComponent();
        }

        private void Grades_Page_Loaded(object sender, RoutedEventArgs e)
        {
           

            Subject_TextBlock.Text = "Subject: ";
            Grade1_TextBlock.Text = "Grade 1: ";
            Grade2_TextBlock.Text = "Grade 2: ";
            Grade3_TextBlock.Text = "Grade 3: ";
            Final_Grade_TextBlock.Text = "Final Grade : ";

            FunctionalityTimer = new System.Timers.Timer();
            FunctionalityTimer.Elapsed += FunctionalityTimer_Elapsed;
            FunctionalityTimer.Interval = 1;
            FunctionalityTimer.Start();
        }

        private void FunctionalityTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            switch(MainWindow.WindowClosing)
            {
                case false:

                    switch(Application.Current == null)
                    {
                        case false:

                            switch(Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    Application.Current.Dispatcher.Invoke(() =>
                                    {
                                        switch(Application.Current.MainWindow == null)
                                        {
                                            case false:

                                                switch(Grade_Displayer_Expanded)
                                                {
                                                    case false:
                                                        Grade_Displayer.Height = 0;
                                                        Grades_Page_Control_Stackpanel.Height = (Fundamentals_of_Programming_Subsection_Button.ActualHeight * 8) + (50 * 8);
                                                        break;

                                                    case true:
                                                        Grades_Page_Control_Stackpanel.Height = 0;
                                                        Grade_Displayer.Height = Subject_TextBlock.ActualHeight * 10;
                                                        break;
                                                }
                                               

                                                switch (Application.Current.MainWindow.WindowState)
                                                {
                                                    case WindowState.Normal:

                                                        
                                                        Title_TextBlock.FontSize = Title_TextBlock_Initial_Font_Size;

                                                        Fundamentals_of_Programming_Subsection_Button.Width = Initial_Fundamentals_of_Programming_Subsection_Button_Width;
                                                        Fundamentals_of_Programming_Subsection_Button.Height = Initial_Fundamentals_of_Programming_Subsection_Button_Height;

                                                        Computer_Systems_Subsection_Button.Width = Initial_Computer_Systems_Subsection_Button_Width;
                                                        Computer_Systems_Subsection_Button.Height = Initial_Computer_Systems_Subsection_Button_Height;

                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Width = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Width;
                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Height = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Height;

                                                        Foundation_Project_Subsection_Button.Width = Initial_Foundation_Project_Subsection_Button_Width;
                                                        Foundation_Project_Subsection_Button.Height = Initial_Foundation_Project_Subsection_Button_Height;

                                                        Databases_Subsection_Button.Width = Initial_Databases_Subsection_Button_Width;
                                                        Databases_Subsection_Button.Height = Initial_Databases_Subsection_Button_Height;

                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Width = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Width;
                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Height = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Height;

                                                        Subject_TextBlock.FontSize = Initial_Subject_TextBlock_Font_Size;

                                                        Go_Back_Button.FontSize = Initial_Go_Back_Button_Font_Size;

                                                        Grade1_TextBlock.FontSize = Initial_Grade1_TextBlock_Font_Size;

                                                        Grade2_TextBlock.FontSize = Initial_Grade2_TextBlock_Font_Size;

                                                        Grade3_TextBlock.FontSize = Initial_Grade3_TextBlock_Font_Size;

                                                        Final_Grade_TextBlock.FontSize = Initial_Final_Grade_TextBlock_Font_Size;

                                                        Subject_TextBlock.FontSize = Initial_Subject_TextBlock_Font_Size;

                                                        Title_StackPanel.Margin = Title_StackPanel_Margin_Top;

                                                        Go_Back_Button.Margin = Go_Back_Button_Margin_Top;

                                                        Grade1_TextBlock.Margin = Grade1_Margin_Top; 

                                                        Grade2_TextBlock.Margin = Grade2_Margin_Top;

                                                        Grade3_TextBlock.Margin = Grade3_Margin_Top;

                                                        Final_Grade_TextBlock.Margin = Final_Grade_Margin_Top;

                                                        break;

                                                    case WindowState.Maximized:
                                                        Title_TextBlock.FontSize = Title_TextBlock_Initial_Font_Size * 2;

                                                        Fundamentals_of_Programming_Subsection_Button.Width = Initial_Fundamentals_of_Programming_Subsection_Button_Width * 2;
                                                        Fundamentals_of_Programming_Subsection_Button.Height = Initial_Fundamentals_of_Programming_Subsection_Button_Height * 2;

                                                        Computer_Systems_Subsection_Button.Width = Initial_Computer_Systems_Subsection_Button_Width * 2;
                                                        Computer_Systems_Subsection_Button.Height = Initial_Computer_Systems_Subsection_Button_Height * 2;

                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Width = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Width * 2;
                                                        Logical_Analisys_And_Problem_Solving_Subsection_Button.Height = Initial_Logical_Analisys_And_Problem_Solving_Subsection_Button_Height * 2;

                                                        Foundation_Project_Subsection_Button.Width = Initial_Foundation_Project_Subsection_Button_Width * 2;
                                                        Foundation_Project_Subsection_Button.Height = Initial_Foundation_Project_Subsection_Button_Height * 2;

                                                        Databases_Subsection_Button.Width = Initial_Databases_Subsection_Button_Width * 2;
                                                        Databases_Subsection_Button.Height = Initial_Databases_Subsection_Button_Height * 2;

                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Width = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Width * 2;
                                                        Fundamentals_of_Software_Engineering_Subsection_Button.Height = Initial_Fundamentals_of_Software_Engineering_Subsection_Button_Height * 2;

                                                        Subject_TextBlock.FontSize = Initial_Subject_TextBlock_Font_Size * 2;

                                                        Go_Back_Button.FontSize = Initial_Go_Back_Button_Font_Size * 2;

                                                        Grade1_TextBlock.FontSize = Initial_Grade1_TextBlock_Font_Size * 2;

                                                        Grade2_TextBlock.FontSize = Initial_Grade2_TextBlock_Font_Size * 2;

                                                        Grade3_TextBlock.FontSize = Initial_Grade3_TextBlock_Font_Size * 2;

                                                        Final_Grade_TextBlock.FontSize = Initial_Final_Grade_TextBlock_Font_Size * 2;

                                                        Title_StackPanel.Margin = new Thickness(0, 80, 0, 0);

                                                        Go_Back_Button.Margin = new Thickness(0, 0, 20, 0);

                                                        Grade1_TextBlock.Margin = new Thickness(0, 100, 0, 0);

                                                        Grade2_TextBlock.Margin = new Thickness(0, 40, 0, 0);

                                                        Grade3_TextBlock.Margin = new Thickness(0, 40, 0, 0);

                                                        Final_Grade_TextBlock.Margin = new Thickness(0, 40, 0, 0);
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

        private void Load_Fundamentals_of_Programming_Subsection_Grades(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            Title_TextBlock.Visibility = Visibility.Hidden;
                                            Grade_Displayer_Expanded = true;

                                            var ParallelProcessing = new System.Threading.Thread(async() =>
                                            {
                                                
                                                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                string grades = await server_Connection.Download_Grades(ID, PASSWORD, "3");
                                                await Grade_Value_Extractor(grades);

                                                Application.Current.Dispatcher.Invoke(() =>
                                                {
                                                    Subject_TextBlock.Text = "Subject: Fundamentals of Programming";

                                                    Grade1_TextBlock.Text = Grade1;

                                                    Grade2_TextBlock.Text = Grade2;

                                                    Grade3_TextBlock.Text = Grade3;

                                                    Final_Grade_TextBlock.Text = Final_Grade;
                                                });
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

        private void Load_Computer_Systems_Subsection_Grades(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            Title_TextBlock.Visibility = Visibility.Hidden;
                                            Grade_Displayer_Expanded = true;

                                            var ParallelProcessing = new System.Threading.Thread(async () =>
                                            {

                                                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                string grades = await server_Connection.Download_Grades(ID, PASSWORD, "0");
                                                await Grade_Value_Extractor(grades);
                                                Application.Current.Dispatcher.Invoke(() =>
                                                {
                                                    Subject_TextBlock.Text = "Subject: Computer Systems";

                                                    Grade1_TextBlock.Text = Grade1;

                                                    Grade2_TextBlock.Text = Grade2;

                                                    Grade3_TextBlock.Text = Grade3;

                                                    Final_Grade_TextBlock.Text = Final_Grade;
                                                });
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

        private void Load_Foundation_Project_Subsection_Grades(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            Title_TextBlock.Visibility = Visibility.Hidden;
                                            Grade_Displayer_Expanded = true;

                                            var ParallelProcessing = new System.Threading.Thread(async () =>
                                            {

                                                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                string grades = await server_Connection.Download_Grades(ID, PASSWORD, "2");
                                                await Grade_Value_Extractor(grades);
                                                Application.Current.Dispatcher.Invoke(() =>
                                                {
                                                    Subject_TextBlock.Text = "Subject: Foundation Project";

                                                    Grade1_TextBlock.Text = Grade1;

                                                    Grade2_TextBlock.Text = Grade2;

                                                    Grade3_TextBlock.Text = Grade3;

                                                    Final_Grade_TextBlock.Text = Final_Grade;
                                                });
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

        private void Load_Logical_Analisys_And_Problem_Solving_Subsection_Grades(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            Title_TextBlock.Visibility = Visibility.Hidden;

                                            var ParallelProcessing = new System.Threading.Thread(async () =>
                                            {
                                                Grade_Displayer_Expanded = true;

                                                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                string grades = await server_Connection.Download_Grades(ID, PASSWORD, "5");
                                                await Grade_Value_Extractor(grades);

                                                Application.Current.Dispatcher.Invoke(() =>
                                                {
                                                    Subject_TextBlock.Text = "Subject: Logical Analysis and Problem Solving";

                                                    Grade1_TextBlock.Text = Grade1;

                                                    Grade2_TextBlock.Text = Grade2;

                                                    Grade3_TextBlock.Text = Grade3;

                                                    Final_Grade_TextBlock.Text = Final_Grade;
                                                });
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

        private void Load_Databases_Subsection_Grades(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            Title_TextBlock.Visibility = Visibility.Hidden;

                                            var ParallelProcessing = new System.Threading.Thread(async () =>
                                            {
                                                Grade_Displayer_Expanded = true;

                                                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                string grades = await server_Connection.Download_Grades(ID, PASSWORD, "1");
                                                await Grade_Value_Extractor(grades);

                                                Application.Current.Dispatcher.Invoke(() =>
                                                {
                                                    Subject_TextBlock.Text = "Subject: Databases";

                                                    Grade1_TextBlock.Text = Grade1;

                                                    Grade2_TextBlock.Text = Grade2;

                                                    Grade3_TextBlock.Text = Grade3;

                                                    Final_Grade_TextBlock.Text = Final_Grade;
                                                });
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

        private void Load_Fundamentals_of_Software_Engineering_Subsection_Grades(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:

                                            Title_TextBlock.Visibility = Visibility.Hidden;

                                            var ParallelProcessing = new System.Threading.Thread(async () =>
                                            {
                                                Grade_Displayer_Expanded = true;

                                                Server_Connection<string, string, string, string, string, string> server_Connection = new Server_Connection<string, string, string, string, string, string>();
                                                string grades = await server_Connection.Download_Grades(ID, PASSWORD, "4");
                                                await Grade_Value_Extractor(grades);
                                                

                                                Application.Current.Dispatcher.Invoke(() =>
                                                {
                                                    Subject_TextBlock.Text = "Subject: Fundamentals of Software Engineering";

                                                    Grade1_TextBlock.Text = Grade1;

                                                    Grade2_TextBlock.Text = Grade2;

                                                    Grade3_TextBlock.Text = Grade3;

                                                    Final_Grade_TextBlock.Text = Final_Grade;
                                                });
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

        private Task<bool> Grade_Value_Extractor(string grades)
        {
            int Count = 0;

            Grade1 = "Grade 1: ";
            Grade2 = "Grade 2: ";
            Grade3 = "Grade 3: ";
            Final_Grade = "Final Grade : ";

            for (int Index = 0; Index <= grades.Length - 1; Index++)
            {
                if ((grades[Index] != '|') && (grades[Index] != '?'))
                {
                    if (Count == 0)
                    {
                        Grade1 += grades[Index];
                    }
                    else if (Count == 1)
                    {
                        Grade2 += grades[Index];
                    }
                    else if (Count == 2)
                    {
                        Grade3 += grades[Index];
                    }
                    else if (Count == 3)
                    {
                        Final_Grade += grades[Index];
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Count++;
                }
            }

            return Task.FromResult(true);
        }

        private void Go_Back_To_The_Main_Menu(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.WindowClosing)
            {
                case false:

                    switch (Application.Current == null)
                    {
                        case false:

                            switch (Application.Current.Dispatcher.HasShutdownStarted)
                            {
                                case false:

                                    switch (Application.Current.MainWindow == null)
                                    {
                                        case false:
                                            Title_TextBlock.Visibility = Visibility.Visible;
                                            Grade_Displayer_Expanded = false;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }

        public void Dispose()
        {
            Grade_Displayer_Expanded = false;
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                try
                {
                    FunctionalityTimer?.Dispose();
                }
                catch { }

                GC.Collect(3, GCCollectionMode.Forced);
            }
        }

        ~GradesPage()
        { 
            GC.Collect(3, GCCollectionMode.Forced); 
        }
    }
}
