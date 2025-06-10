using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_099 : SimTemplate //* 克罗斯·龙蹄 Kronx Dragonhoof
	{
		//[x]<b>Battlecry:</b> Draw Galakrond.If you're already Galakrond,unleash a Devastation.
		//<b>战吼：</b>抽取迦拉克隆。如果你已经变为迦拉克隆，则释放一场灾难。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_099t2t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
				{
					int dmg = (own.own) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
					p.minionGetDamageOrHeal(own.own ? p.enemyHero : p.ownHero, dmg);
					int heal = (own.own) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);
				}
				if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
				{
					int pos = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(kid, pos, own.own, false);
				}
				if (choice == 3 || (p.ownFandralStaghelm > 0 && own.own))
				{
					List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
					foreach (Minion m in temp)
					{
						if (target.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 2);
					}
				}
				if (choice == 4 || (p.ownFandralStaghelm > 0 && own.own))
				{
					int dmg = (own.own) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
					p.allMinionsGetDamage(dmg);
				}
			}
		}
	}
}