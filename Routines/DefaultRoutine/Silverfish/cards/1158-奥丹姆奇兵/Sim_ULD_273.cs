using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_273 : SimTemplate //* 溢流 Overflow
	{
		//Restore #5 Healthto all characters.Draw 5 cards.
		//为所有角色恢复#5点生命值。抽五张牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{			
			int heal = 5;
			foreach (Minion m in p.ownMinions)
			{
				p.minionGetDamageOrHeal(m, -heal);
			}
			foreach (Minion m in p.enemyMinions)
			{
				p.minionGetDamageOrHeal(m, -heal);
			}

			p.minionGetDamageOrHeal(p.enemyHero, -heal);
			p.minionGetDamageOrHeal(p.ownHero, -heal);

			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
	}
}