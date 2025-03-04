﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EmployeeDTO
    {
        private int empid;
        private String lastname;
        private String firstname;
        private String fullname;
        private String title;
        private String titleofcourtesy;
        private DateTime? birthdate;
        private DateTime? hiredate;
        private String address;
        private String city;
        private String region;
        private String postalcode;
        private String country;
        private String phone;
        private String mgrid;
        private String extension;
        private String notes;
        private String photopath;

        public int Empid { get; set; }
        public String Lastname { get; set; }
        public String Firstname { get; set; }
        public String FullName { get { return Lastname + " " + Firstname; } }
        public String Title { get; set; }
        public String Titleofcourtesy { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? Hiredate { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String Postalcode { get; set; }
        public String Country { get; set; }
        public String Phone { get; set; }
        public int Mgrid { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public string PhotoPath { get; set; }
    }
}
