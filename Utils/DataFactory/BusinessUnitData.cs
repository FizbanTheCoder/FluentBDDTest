using System;
using System.Collections.Generic;
using System.Text;

namespace IFlow.Testing.Utils.DataFactory
{
    public static class BusinessUnitData
    {
        public static string Name => new Bogus.Faker().Company.Random.Words(1);
    }
}
