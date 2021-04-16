using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (BookContext db = new BookContext()) //Создание подключения
            {
                //Объявление объектов
                Buyers player1 = new Buyers() { Name="Алексей", Surname="Ганцевич"};
                Books books1 = new Books() { Uzdanie = "2014", Price = 200 };

                //Добавление объектов в контекст
                db.Buyers.Add(player1);
                db.books.Add(books1);

                db.SaveChanges(); //Чтобы добавленные объекты отправились в базу данных, нужно вызвать метод, сохраняющий изменения

                
            }
        }
    }
}
