using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRAH52_HFT_2021221.Logic;
using Moq;
using CRAH52_HFT_2021221.Repository;
using CRAH52_HFT_2021221.Models;

namespace CRAH52_HFT_2021221.Test
{
    [TestFixture]
    class ClubsLogicTest
    {
        IClubsLogic clubsLogic;
        
        
        public void Setup()
        {
            Mock<IClubsRepository> mockrepo = new Mock<IClubsRepository>();
            Clubs otkert = new Clubs { ClubID = 1,};
            Clubs madam = new Clubs { ClubID = 2 };
            Clubs yellow = new Clubs { ClubID = 3 };

            Events onedance = new Events { ClubID = otkert.ClubID, Date = "2021 06 05", Clubs = otkert };
            Events onenight = new Events { ClubID = madam.ClubID, Date = "2021 07 05", Clubs = madam };
            Events yellownight = new Events { ClubID = yellow.ClubID, Date = "2021 01 25", Clubs = yellow };
            Events girlsnight = new Events { ClubID = yellow.ClubID, Date = "2021 10 05", Clubs = yellow };
            
            otkert.Events = onedance;
            madam.Events = onenight;
            yellow.Events = yellownight;
            yellow.Events = girlsnight;
            mockrepo.Setup(x => x.ReadAll())
                .Returns(new List<Clubs>()
                {otkert,madam,yellow
                }.AsQueryable());
            clubsLogic = new ClubsLogic(mockrepo.Object);
        }



        [Test]
        public void CheckTheMostPopularCLub()
        {
            //ACT
            var result = clubsLogic.ClubsThatHeldEventsInTheSummer();
            //ASSERT
            Assert.That(result.FirstOrDefault().ClubID, Is.EqualTo(3));
        }
        //[Test]
        //public void CheckClubsThatHeldEventsInTheSummer()
        //{

        //}
        //[Test]
        //public void CheckCreate()
        //{

        //}
    }
}
