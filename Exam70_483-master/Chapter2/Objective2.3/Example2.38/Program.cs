﻿using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Example2._38
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will not complie
            DbContext ctx = new DbContext("Non existing connection string");
            //var context = ctx.ObjectContext;

            var adapterContext = ((IObjectContextAdapter)ctx).ObjectContext;
        }
    }

    //public interface IObjectContextAdapter
    //{
    //    ObjectContext ObjectContext { get; }
    //}
}
