using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_285t4 : SimTemplate //* 尖刺盾牌 Spiked Shield
//Gain 5 Armor.Equip a 5/2 weapon.
//获得5点护甲值。装备一把5/2的武器。 
	{
		
		
		CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_285t4t);
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 5);	
			p.equipWeapon(wcard, true);			
		}
	}
}