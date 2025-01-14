﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagementSystem.Enums;

namespace CafeManagementSystem.DTO
{
    public class Table
    {
        private int id;
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int numPeople;
        public int NumPeople
        {
            get { return numPeople; }
            set { numPeople = value; }
        }
        private TableStatus status;
        public TableStatus Status { get => status; set => status = value; }
        
        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }


        public Table(int id, string name, int numPeople, TableStatus status, TableColor color, string location)
        {
            this.id = id;
            this.name = name;
            this.numPeople = numPeople;
            this.status = status;
            this.location = location;
        }
        public Table(DataRow row)
        {
            this.id = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.status = (TableStatus)row["Status"];
            this.location = row["Location"].ToString();
        }
    }
}
