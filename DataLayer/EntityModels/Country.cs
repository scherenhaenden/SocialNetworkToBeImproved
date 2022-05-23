using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.EntityModels
{
    public class Country:Entity, IEntity
    {
        public string Name { get; set; }
        public string AlphaTwoCode { get; set; }
        public string AlphaThreeCode { get; set; }
    }
}
