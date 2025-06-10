using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_091: SimTemplate //* 亡者之牌 Dead Man's Hand
//Shuffle a copy of your hand into your deck.
//复制你的手牌并洗入你的牌库。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.ownDeckSize += p.owncards.Count;
            else p.enemyDeckSize += p.enemyAnzCards;
        }
    }
}