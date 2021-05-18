using System.Collections.Generic;
using trains.Models;

namespace trains.DB
{
    public class FakeDB
    {
        public static List<Train> Trains { get; set; } = new List<Train>(){
            new Train("Thomas", 350000, "Interdimensional harbinger of death")
        };
    }
}