using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaWall.Models;

namespace MediaWall.DAL
{
    public static class AlumniDBInitilizer
    {
        public static void Initialize(AlumniContext context)
        {
            context.Database.EnsureCreated();
            if (context.Alum.Any())
            {
                return; //if the db already has data.
            }

            #region Alumni Seed
            var alum = new Alum[]
            {
                new Alum { Fname = "FirstName1", Lname="LastName1", Photodate= DateTime.MinValue, Graddate=DateTime.MaxValue, Biography="Hello", IsDistinguished= false, Maidenname="MaidenName1", Mname="MName1" },
                new Alum { Fname = "FirstName2", Lname="LastName2", Photodate= DateTime.MinValue, Graddate=DateTime.MaxValue, Biography="Hello", IsDistinguished= false, Maidenname="MaidenName2", Mname="MName2" },
                new Alum { Fname = "FirstName3", Lname="LastName3", Photodate= DateTime.MinValue, Graddate=DateTime.MaxValue, Biography="Hello", IsDistinguished= false, Maidenname="MaidenName3", Mname="MName3" }
            };
            foreach (Alum a in alum)
            {
                context.Alum.Add(a);
            }
            context.SaveChanges();
            #endregion
            
            #region Class Seed
            var cls = new Class[]
            {
                new Class { Program="BSN", Term="Spring", Year=2016 },
                new Class { Program="MSN", Term="Summer", Year=2016 },
                new Class { Program="PHD", Term="Fall", Year=2016 }
            };
            foreach (Class c in cls)
            {
                context.Class.Add(c);
            }
            context.SaveChanges();
            #endregion

            #region Pictures Seed
            var pics = new Pictures[]
            {
                new Pictures { Alt="alt text1", Caption="caption1", Description="this is a desc1", DisplayYear=new DateTime(2016,1,1), ImageLocation="http://some.location1" },
                new Pictures { Alt="alt text2", Caption="caption2", Description="this is a desc2", DisplayYear=new DateTime(2016,2,1), ImageLocation="http://some.location2" },
                new Pictures { Alt="alt text3", Caption="caption3", Description="this is a desc3", DisplayYear=new DateTime(2016,3,1), ImageLocation="http://some.location3" }
            };
            foreach(var p in pics)
            {
                context.Pictures.Add(p);
            }
            context.SaveChanges();
            #endregion


        }
    }
}
