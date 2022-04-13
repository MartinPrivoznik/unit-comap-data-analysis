using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestHead
    {
        [Key]
        public long Id  { get; set; }
        public Product Product { get; set; }
        public Result Result { get; set; }
        public DateTime DateSOfTesting { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string SN { get; set; }
    }

    public class Result
    {
        public bool Success { get; set; }
    }
}
