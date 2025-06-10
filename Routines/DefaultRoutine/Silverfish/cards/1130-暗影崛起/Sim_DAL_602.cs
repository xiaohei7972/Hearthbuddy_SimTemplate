using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_602 : SimTemplate //* 情势反转 Plot Twist
//Shuffle your handinto your deck.Draw that many cards.
//将你的手牌洗入牌库。抽取同样数量的牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int bonus = 0;
            if (ownplay) bonus = -2 * p.owncards.Count;
            else bonus = 2 * p.enemyAnzCards;
			p.evaluatePenality += bonus;
		}
	}
}