using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManager.Model
{
    public class Users
    {
        int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        int sex;

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        string favorite;

        public string Favorite
        {
            get { return favorite; }
            set { favorite = value; }
        }
        int cityID;

        public int CityID
        {
            get { return cityID; }
            set { cityID = value; }
        }
    }
}
