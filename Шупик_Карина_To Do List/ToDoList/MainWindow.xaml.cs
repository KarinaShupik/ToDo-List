using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Task> tasksList = new ObservableCollection<Task>();

        public MainWindow()
        {
            InitializeComponent();

            /*Task t1 = new Task();
            t1.Name = "Купити молоко";
            t1.Description = "Купити молоко 5%";
            t1.IsCompleted = false;

            Task t2 = new Task();
            t2.Name = "Погуляти з собокою";
            t2.Description = "Погуляти з собакою та купити корм";
            t2.IsCompleted = false;

            Task t3 = new Task();
            t3.Name = "Піти до стоматолога";
            t3.Description = "Піти до стоматолога та купити засоби гігієни";
            t3.IsCompleted = false;

            tasksList.Add(t1);
            tasksList.Add(t2);  
            tasksList.Add(t3);  */

            ToDoBox.ItemsSource = tasksList;
            ToDoBox.DisplayMemberPath = "Name";
        }

        private void ToDoBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Task selected = ToDoBox.SelectedItem as Task;
            if(selected != null) 
            {
                MessageBox.Show(selected.Description);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NewTaskWindow window = new NewTaskWindow(); 
            window.Owner = this;    
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            if (window.ShowDialog() == true)
            {
                Task newTask = window.Result;
                tasksList.Add(newTask);
            }
                
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ToDoBox.SelectedIndex;
            if(index != -1) 
            {
                tasksList.RemoveAt(index);  
            }
        }

        private void CompleteButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ToDoBox.SelectedIndex;
            if (index != -1)
            {
                tasksList[index].IsCompleted = true;
            }
        }

        private void AllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ToDoBox.ItemsSource = tasksList;
        }

        private void NotCompleted_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Task> filtered = new ObservableCollection<Task>();
            for (int i = 0; i < tasksList.Count; i++) 
            { 
                Task current = tasksList[i];   
                if(current.IsCompleted == false)
                {
                    filtered.Add(current);  
                }
            }
            ToDoBox.ItemsSource = filtered;
        }

        private void Completed_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Task> filtered = new ObservableCollection<Task>();
            for (int i = 0; i < tasksList.Count; i++)
            {
                Task current = tasksList[i];
                if (current.IsCompleted == true)
                {
                    filtered.Add(current);
                }
            }
            ToDoBox.ItemsSource = filtered;
        }


        string fileName = "data.bin";

        private void Window_Closed(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream file = File.OpenWrite(fileName);
            formatter.Serialize(file, tasksList);
            file.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream file = File.OpenRead(fileName);
                tasksList = formatter.Deserialize(file) as ObservableCollection<Task>;
                file.Close();
                ToDoBox.ItemsSource = tasksList;    
            }
        }
    }
}
