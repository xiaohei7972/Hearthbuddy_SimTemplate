using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_333 : SimTemplate //* 库尔特鲁斯·陨烬 Kurtrus Ashfallen
	{
		//[x]<b>Battlecry:</b> Attack the left andright-most enemy minions.<b>Outcast:</b> <b>Immune</b> this turn.
		//<b>战吼：</b>攻击最左边和最右边的敌方随从。<b>流放：</b>在本回合中获得<b>免疫</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				foreach (Minion m in p.ownMinions)
				{
					if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.BAR_333)
					{
						m.immune = true;
						break;
					}
				}
			}
			foreach(Minion m in p.ownMinions)
            {
				if(m.handcard.card.cardIDenum == CardDB.cardIDEnum.BAR_333)
                {
					if (p.enemyMinions.Count > 1)
					{
						p.minionAttacksMinion(m, p.enemyMinions[0]);
						p.minionAttacksMinion(m, p.enemyMinions[p.enemyMinions.Count - 1]);
					}else if(p.enemyMinions.Count == 1)
                    {
						p.minionAttacksMinion(m, p.enemyMinions[0]);
					}
					break;
                }
            }
		}

	}
}
