using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_091 : SimTemplate //* 铁炉堡传送门 Ironforge Portal
//Gain 4 Armor.Summon a random4-Cost minion.
//获得4点护甲值。随机召唤一个法力值消耗为（4）的随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 4);	
			
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getRandomCardForManaMinion(4), pos, ownplay);
		}
	}
}