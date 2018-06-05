using System.Collections.Generic;
using NUnit.Framework;
using UnityDemo.Models;
using UnityDemo.Models.Scorers;

namespace Assets.Tests
{
    class BasicScorerTest_문슬기범
    {
        [SetUp]
        public void Init()
        {
            //            Deck.Instance.PrepareNewRound();
        }

        [Test]
        public void 광땡으로_이기는_경우()
        {
            Scorer scorer = new SimpleScorer();
            Player p1 = new Player("A");
            p1.AddCard(new Card(4, false));
            p1.AddCard(new Card(4, false)); //40점

            Player p2 = new Player("B");
            p2.AddCard(new Card(4, true)); //9점
            p2.AddCard(new Card(5, true)); //101점

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }

        [Test]
        public void 땡으로_이기는_경우()
        {
            Scorer scorer = new SimpleScorer();
            Player p1 = new Player("A");
            p1.AddCard(new Card(4, false));
            p1.AddCard(new Card(4, false));

            Player p2 = new Player("B");
            p2.AddCard(new Card(4, true));
            p2.AddCard(new Card(8, true));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

        [Test]
        public void 끗으로_이기는_경우()
        {
            Scorer scorer = new SimpleScorer();
            Player p1 = new Player("A");
            p1.AddCard(new Card(8, false));
            p1.AddCard(new Card(9, false));

            Player p2 = new Player("B");
            p2.AddCard(new Card(4, true));
            p2.AddCard(new Card(2, true));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }

    }
}
