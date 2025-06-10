using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_042 : SimTemplate //* 武器计划 Weapons Project
//Each player equips a 2/3 Weapon andgains 6 Armor.
//每个玩家装备一把2/3的武器，并获得6点护甲值。 
	{



        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_042t);
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 6);
				p.minionGetArmor(p.enemyHero, 6);
            }
            else
            {
                p.minionGetArmor(p.ownHero, 6);
				p.minionGetArmor(p.enemyHero, 6);
            }
            p.equipWeapon(w, true);
            p.equipWeapon(w, false);
		}

	}
}