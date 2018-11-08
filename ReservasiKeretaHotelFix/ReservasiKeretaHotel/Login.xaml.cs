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
using ReservasiKeretaHotel.BaseContext;
using ReservasiKeretaHotel.Model;

namespace ReservasiKeretaHotel
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    /// 


    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        MyContext context = new MyContext();
        Account akun = new Account();
        Admin admin = new Admin();

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            if (Uname.Text == "")
            {
                MessageBox.Show("Email Harus di Isi");
            }
            else if (Pass.Text == "")
            {
                MessageBox.Show("Password Harus di Isi");
            }
            else if (Uname.Text.Equals("") && Pass.Text.Equals(""))
            {
                MessageBox.Show("Email dan password haru di Isi");
            }
            else
            {
                var UserCostumer = context.accounts.Where(x => x.Email == Uname.Text && x.Password == Pass.Text).ToList();
                var UserAdmin = context.admins.Where(x => x.username == Uname.Text && x.password == Pass.Text).ToList();
                if (UserCostumer.Count!=0)
                {
                    SearchTiket search = new SearchTiket();
                    this.Close();
                    search.Show();
                    
                }
                else if (UserAdmin.Count !=0 )
                {
                    admintrain main = new admintrain();
                    this.Close();
                    main.Show();
                    
                    
                }

            }
        }
    }
}
    
