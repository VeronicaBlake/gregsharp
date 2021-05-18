using System;
using System.Collections.Generic;
using trains.DB;
using trains.Models;

namespace gregsharp.Services
{
    public class TrainsService
    {
        internal IEnumerable<Train> GetAll()
        {
            return FakeDB.Trains;
        }

        internal Train GetById(string id)
        {
            Train found = FakeDB.Trains.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

        internal Train Create(Train newTrain)
        {
            FakeDB.Trains.Add(newTrain);
            return newTrain;
        }
    }
}