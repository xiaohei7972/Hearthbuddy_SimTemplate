using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX9_05H : SimTemplate //* 符文剑 Runeblade
//Has +6 Attack if the other Horsemen are dead.
//如果其他天启骑士死亡，获得+6攻击力。 
	{
		
		
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX9_05H);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(weapon, ownplay);
			if (ownplay)
            {
				if (p.anzOwnHorsemen < 1)
				{
					p.ownWeapon.Angr += 6;
					p.minionGetBuffed(p.ownHero, 6, 0);
				}
            }
            else 
            {
				if (p.anzEnemyHorsemen < 1)
				{
					p.enemyWeapon.Angr += 6;
					p.minionGetBuffed(p.enemyHero, 6, 0);
				}
            }
		}
	}
}