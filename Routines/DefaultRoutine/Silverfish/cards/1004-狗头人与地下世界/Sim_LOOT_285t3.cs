using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_285t3 : SimTemplate //* 符文盾牌 Runed Shield
//Gain 5 Armor.Summon a 5/5 Golem.
//获得5点护甲值。召唤一个5/5的魔像。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_285t3t);
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 5);			
		}
	}
}