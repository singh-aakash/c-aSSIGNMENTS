using System;
using System.Collections.Generic;
using System.Text;


namespace EmpInfo
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmpId { get; set; }
        public string EmpPhone { get; set; }
        public string Address { get; set; }


        private string _empTweetID;
        public string EmpTweetID
        {
            get { return _empTweetID; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _empTweetID = value;
                }
                else
                {
                    throw new Exception("Please Start Tweet ID with @ sign");
                }
            }
        }
    }
}
