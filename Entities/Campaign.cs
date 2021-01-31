using System;
using Homework5.Abstract;

namespace Homework5.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountPercentage { get; set; }
    }
}
