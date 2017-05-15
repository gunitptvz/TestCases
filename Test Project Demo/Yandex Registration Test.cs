using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Demo
{
    [TestFixture]
    public class YandexRegistrationTest
    {
        [Test,TestCaseSource("RegisterData()")]
        public void TestRegister(string username, string password, string email, string city)
        {
            // selenium code
            // username
            // password
            // email
            // city

            Console.WriteLine("username {0}, password {1}, email {2}, city {3}", username, password, email, city);
        }

        // data source

        public object[,] RegisterData()
        {
            // rows - no of times test has to be executed
            // columns - no of parameters in data
            object [,] data = new object[3,4];

            // first row
            data[0, 0] = "user1";
            data[0, 1] = "password1";
            data[0, 2] = "email1";
            data[0, 3] = "city1";

            // second row
            data[1, 0] = "user2";
            data[1, 1] = "password2";
            data[1, 2] = "email2";
            data[1, 3] = "city2";

            // third row
            data[2, 0] = "user3";
            data[2, 1] = "password3";
            data[2, 2] = "email3";
            data[2, 3] = "city3";

            return data;
        }
    }
}
