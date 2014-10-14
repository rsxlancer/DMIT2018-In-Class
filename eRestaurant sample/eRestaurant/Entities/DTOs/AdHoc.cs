using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities.DTOs
{
    public class AdHoc
    {
        //A class has fields, properties, constructors, and methods
    }
    public interface IAdHoc
    {
        //An interface has fields, methods, properties and methods.
        string name;
        //Properties and methods do NOT have implimentation in an interface
        string AsText(int value);
        int Count { get; } //Properties can have a get, set, or both
    }
}
