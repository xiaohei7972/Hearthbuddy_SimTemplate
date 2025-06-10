using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_007 : SimTemplate //* 拉法姆的诅咒 Curse of Rafaam
//Give your opponent a 'Cursed!' card.While they hold it, they take 2 damage on their turn.
//使你的对手获得一张“诅咒”。在对手的回合开始时，如果它在对手的手牌中，则造成2点伤害。 
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(p.enemyHero, 2);
        }


    }
}
