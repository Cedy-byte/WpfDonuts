using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WpfDonuts
{
    public class Order
    {
        string name, phoneNo;
        int donuts, coffee;

        public Order(string name, string phoneNo, int donuts, int coffee)
        {
            this.Name = name;
            this.Donuts = donuts;
            this.Coffee = coffee;
            this.PhoneNo = PhoneNo;
            donutsReady = false;
            coffeeReady = false;
        }

        public bool donutsReady { get; set; }
        public bool coffeeReady { get; set; }


        public string Name { get => name; set => name = value; }

        [Range(1, 100, ErrorMessage = "Donuts must be between 1 and 100")]
        public int Donuts { get => donuts; set => donuts = value; }

        [Range(1, 100, ErrorMessage = "Coffee must be between 1 and 100")]
        public int Coffee { get => coffee; set => coffee = value; }

        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter a phone number with 10 digits")]
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }

        public override string ToString()
        {
            return (name + " - " + donuts + "donuts and " + coffee + "coffees.");
        }
    }
}
