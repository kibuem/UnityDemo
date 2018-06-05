﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityDemo.Models;
using UnityEngine;

public class DeckTest
{
    [Test]
    public void 덱에는_광이_3장있어야_함()
    {
        Deck.Instance.PrepareNewRound();

        List<Card> cards = new List<Card>();
        for (int i = 0; i < 20; i++)
        {
            Card card = Deck.Instance.Draw();
            cards.Add(card);
        }

//        int kwangCount = 0;
//        foreach (var card in cards)
//            if (card.IsKwang)
//                kwangCount++;
        int kwangCount = cards.Count(i => i.IsKwang);

        Assert.AreEqual(3, kwangCount);
    }

    [Test]
    public void 덱에는_1부터_10까지의_카드가_2장씩_있어야_함()
    {
        Deck.Instance.PrepareNewRound();

        List<Card> cards = new List<Card>();
        for (int i = 0; i < 20; i++)
        {
            Card card = Deck.Instance.Draw();
            cards.Add(card);
        }

        for (int no = 1; no <= 10; no++)
        {
            int numberCount = cards.Count(x => x.No == no);
            Assert.AreEqual(2, numberCount);
        }
    }
}