using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_714 : SimTemplate //* 下水道销赃人 Underbelly Fence
//[x]<b>Battlecry:</b> If you're holdinga card from another class,_gain +1/+1 and <b><b>Rush</b>.</b>
//<b>战吼：</b>如果你手牌中有其他职业的卡牌，则获得+1/+1和<b>突袭</b>。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
                int heroClass = (int)p.ownHeroStartClass;
				foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.Class != heroClass && hc.card.Class != 0) 
					{
						p.minionGetBuffed(own, 1, 1);
						p.minionGetRush(own); 
					}
                }
			}
		}
	}
}