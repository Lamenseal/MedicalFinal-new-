﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical
{
    public class CoreLinePay
    {
        public class LinePayRequest

        {
            public int amount { get; set; }

            public string currency { get; set; }

            public string orderId { get; set; }

            public List<Package> packages { get; set; }

            public Options options { get; set; }

            public Redirecturls redirectUrls { get; set; }

        }

        public class Package

        {

            public string id { get; set; }

            public int amount { get; set; }

            public string name { get; set; }

            public List<Product2> products { get; set; }

        }

        public class Product2

        {
            public string id { get; set; }

            public string name { get; set; }

            public string imageUrl { get; set; }

            public int quantity { get; set; }

            public int price { get; set; }

        }

        public class Options

        {
            public Payment payment { get; set; }

        }

        public class Payment

        {

            public bool capture { get; set; }

        }

        public class Redirecturls

        {

            public string confirmUrl { get; set; }

            public string cancelUrl { get; set; }

        }
    }
}
