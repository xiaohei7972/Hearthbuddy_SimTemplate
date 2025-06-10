using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_151 : SimTemplate //* 拉穆卡恒驯兽师 Ramkahen Wildtamer
//<b>Battlecry:</b> Copy a random Beast in your hand.
//<b>战吼：</b>随机复制一张你手牌中的野兽牌。 
	{
		
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			if(m.own)
			{
				if (target != null)
				{
					foreach (Handmanager.Handcard hc in p.owncards)
					{
						p.drawACard(CardDB.cardNameEN.unknown, m.own);
					}
				}
			}
        }
    }
}