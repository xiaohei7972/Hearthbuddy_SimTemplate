using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_101 : SimTemplate //* 禁忌畸变 Forbidden Shaping
//Spend all your Mana. Summon a random minion that costs that much.
//消耗你所有的法力值，随机召唤一个法力值消耗相同的随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int anz = (ownplay) ? p.mana : p.enemyMaxMana;
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getRandomCardForManaMinion(anz), pos, ownplay, false);
			if (ownplay) p.mana = 0;
		}
	}
}