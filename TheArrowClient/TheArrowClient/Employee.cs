using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheArrowClient
{
    internal class Employee
    {
        public Bitmap photo;
        public string lastName;
        public string firstName;
        public string middleName;
        public string position;
        public string department;
        public string place;
        public string company;
        public string eMail;
        public string internalPhoneNumber;
        public string cellPhoneNumber;

        public Employee()
        { }

        public Employee(Bitmap photo, string lastName, string firstName, string middleName, string position, string department, 
            string place, string company, string eMail, string internalPhoneNumber, string cellPhoneNumber)
        {
            this.photo = photo;
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.position = position;
            this.department = department;
            this.place = place;
            this.company = company;
            this.eMail = eMail;
            this.internalPhoneNumber = internalPhoneNumber;
            this.cellPhoneNumber = cellPhoneNumber;
        }

    }   
}
