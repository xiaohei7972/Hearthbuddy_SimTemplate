using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_417 : SimTemplate //* 大灾变 Cataclysm
//Destroy all minions. Discard your hand.
//消灭所有随从。弃掉你的手牌。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int ownanz = p.ownMinions.Count;
            int enemanz = p.enemyMinions.Count;
            p.allMinionsGetDestroyed();
            p.discardCards(10, ownplay);
		}
	}
}