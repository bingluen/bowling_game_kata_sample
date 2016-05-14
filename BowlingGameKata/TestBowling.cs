using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    [TestFixture]
    public class TestBowling
    {

        [Test]
        public void AllZero()
        {
            List<Game.set> pins = new List<Game.set>();
            for (int i = 0; i < 10; i++ )
               pins.Add(new Game.set(0, 0, 0, false));

            Assert.That(Game.GetScore(pins), Is.EqualTo(0));
        }

        [Test]
        public void AllOnes()
        {
            List<Game.set> pins = new List<Game.set>();
            for (int i = 0; i < 10; i++ )
                pins.Add(new Game.set(1, 1, 0, false));

            Assert.That(Game.GetScore(pins), Is.EqualTo((1+1)*10));
        }

        [Test]
        public void OneStrike()
        {
            List<Game.set> pins = new List<Game.set>();
            pins.Add(new Game.set(10, 0, 0, true));
            for (int i = 0; i < 9; i++)
                pins.Add(new Game.set(1, 1, 0, false));
            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 1 + 1) + (1 + 1)* 9));
        }
/*
        [Test]
        public void TwoStrike()
        {
            List<int> pins = new List<int> 
            {
                10,0,  10,0,  1,1,  1,1,  1,1, 
                1,1,   1,1,  1,1,  1,1,  1,1,0 
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10+10+1)+(10 + 1 + 1)*1 + (1 + 1)*8));
        }*/

    /*    [Test]
        public void AllStrike()
        {
            List<int> pins = new List<int> 
            {
                10,0,  10,0,  10,0,  10,0,  10,0, 
                10,0,  10,0,  10,0,  10,0,  10,10,10 
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
             300);
        }*/
    }
}
