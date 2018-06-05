using System.Collections.Generic;
using NUnit.Framework;
using UnityDemo.Models;
using UnityDemo.Models.Scorers;

namespace Assets.Tests
{
    class BasicScorerTest_문슬기범
    {
        [Test]
        public void 광땡으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("A");
            p1.AddCard(new Card(1, false));
            p1.AddCard(new Card(8, false)); //9점

            Player p2 = new Player("B");
            p2.AddCard(new Card(3, true)); //1점
            p2.AddCard(new Card(8, true)); //101점

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }

        [Test]
        public void 땡으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("A");
            p1.AddCard(new Card(5, false));
            p1.AddCard(new Card(4, false)); //9점

            Player p2 = new Player("B");
            p2.AddCard(new Card(3, false)); //6점
            p2.AddCard(new Card(3, true)); //60점

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }

        [Test]
        public void 끗으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("A");
            p1.AddCard(new Card(9, false));
            p1.AddCard(new Card(5, false)); //4점

            Player p2 = new Player("B");
            p2.AddCard(new Card(1, true));
            p2.AddCard(new Card(2, false)); //3점

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

    }
}
