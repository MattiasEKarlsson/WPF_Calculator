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

namespace ContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clearfield() 
        {
            TbFirstname.Text = "";
            TbLastname.Text = "";
        
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var contact = new Contact(TbFirstname.Text, TbLastname.Text);

            try
            {
                lbContactlist.Items.Add(contact.FullName);
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\workerservice\Contacts\WriteLines2.txt", true)) 
                {
                    file.WriteLine(contact.FullName);
                }
            }
            catch
            {
            }
            finally 
            {
                Clearfield();
            
            }



        }


        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbContactlist.Items.Remove(lbContactlist.Items[lbContactlist.SelectedIndex]);
            }
            catch
            {

                
            }
        }
    }
}
