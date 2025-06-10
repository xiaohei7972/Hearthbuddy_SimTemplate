using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_005 : SimTemplate //* 海盗谈判 Parrrley
    {
        //交换此牌与你对手牌库中的一张牌。
        //Swap this for a card in your opponent's deck.
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
        {
            //p.minionReturnToDeck(target, ownplay);
        }
    }
}
