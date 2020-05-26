using MultiThreadTasks.Model.JobExecution;
using MultiThreadTasks.Model.TaskLauncher;
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

namespace MultiThreadTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SyncroPalindromeJob syncro = new SyncroPalindromeJob();
        AsyncPalindromeJob async = new AsyncPalindromeJob();
        MultiThreadPalindromeJob multi = new MultiThreadPalindromeJob();
        Launcher launcher = new Launcher();
        public MainWindow()
        {

            InitializeComponent();  
            
            
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            launcher.StartTimer();
            syncro.palindromeContester = Polyn.Text;
            result.Content = syncro.Execute();
            Time.Content = launcher.GetExecutionTime();
        }

        private void asynccheck_Click(object sender, RoutedEventArgs e)
        {
            launcher.StartTimer();
            async.palindromeContester = Polyn.Text;
            result.Content = async.Execute();
            Time.Content = launcher.GetExecutionTime();
        }

        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            launcher.StartTimer();
            multi.palindromeContester = Polyn.Text;
            result.Content = multi.Execute();
            Time.Content = launcher.GetExecutionTime();
        }
    }
}
