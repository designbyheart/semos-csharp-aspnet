using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQJoin {
  class Program {
    static void Main(string[] args) {
      List<Musician> people = new List<Musician> {
        new Musician{ MusicianId=1, Name="Sonny Rollings"},
        new Musician{ MusicianId=2, Name="Miles Davis"},
        new Musician{ MusicianId=3, Name="John Coltrane"},
        new Musician{ MusicianId=4, Name="Charlie Parker"},
        new Musician{ MusicianId=5, Name="Bela Fleck"},
      };
      List<Instruments> instruments = new List<Instruments>{
        new Instruments{InstrumentId=1, Name="Soprano Saxophone"},
        new Instruments{InstrumentId=2, Name="Tenor Saxophone"},
        new Instruments{InstrumentId=3, Name="Trumpet"},
        new Instruments{InstrumentId=4, Name="Keyboards"},
      };
      List<Order> orders = new List<Order> {
        new Order{ OrderId=1, MusicianId=1, InstrumentId=2},
        new Order{ OrderId=2, MusicianId=2, InstrumentId=3},
        new Order{ OrderId=3, MusicianId=3, InstrumentId=1},
        new Order{ OrderId=4, MusicianId=3, InstrumentId=2},
        new Order{ OrderId=5, MusicianId=4, InstrumentId=2},
        new Order{ OrderId=6, MusicianId=2, InstrumentId=4},
      };

      //var query = from p in people
      //            join o in orders on p.MusicianId equals o.MusicianId
      //            select new { Musician = p.Name, OrderId = o.OrderId };

      //var query = from p in people
      //            join o in orders on p.MusicianId equals o.MusicianId
      //            join i in instruments on o.InstrumentId equals i.InstrumentId
      //            select new { Musician = p.Name, OrderId = o.OrderId, Instrument = i.Name };

      // foreach (var item in query) Console.WriteLine(item);

      //Group Join
      //var query = from p in people
      //            join o in orders on p.MusicianId equals o.MusicianId
      //            into orderGroups
      //            select new { Musician = p.Name, Orders = orderGroups };
      //
      //foreach (var items in query) {
      //  Console.WriteLine(items.Musician);
      //  foreach (var item in items.Orders)
      //    Console.WriteLine("..OrderId:{0}", item.OrderId);
      //}

      
      //var query = from p in people
      //            join o in orders on p.MusicianId equals o.MusicianId
      //            into orderGroups
      //            select new { 
      //              Musician = p.Name, 
      //              Orders = from o in orderGroups 
      //                       join i in instruments on o.InstrumentId equals i.InstrumentId
      //                       select i.Name

      //            };

      //foreach (var items in query) {
      //  Console.WriteLine(items.Musician);
      //  foreach(var item in items.Orders) 
      //    Console.WriteLine("..{0}",item);
      //}

      //Left outer join
      var query0 = from o in orders
                  join i in instruments on o.InstrumentId equals i.InstrumentId
                  select new { o.OrderId, o.MusicianId, i.Name };
      var query = from p in people
                  join o in query0 on p.MusicianId equals o.MusicianId into m
                  from x in m.DefaultIfEmpty()
                  select new { p, x };

      foreach (var items in query)
        Console.WriteLine("{0}{1}",items.p.Name, items.x);


      Console.ReadKey();
    }
  }
}
