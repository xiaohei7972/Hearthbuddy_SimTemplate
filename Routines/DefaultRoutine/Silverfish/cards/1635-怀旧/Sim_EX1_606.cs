using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_606 : SimTemplate //* 盾牌格挡 Shield Block
	{
		//Gain 5 Armor.Draw a card.
		//获得5点护甲值。抽一张牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 5);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 5);
            }
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}