using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：2 攻击力：2 生命值：2
	//Grimestreet Outfitter
	//污手街供货商
	//<b>Battlecry:</b> Give all minions in your hand +1/+1.
	//<b>战吼：</b>使你手牌中的所有随从牌获得+1/+1。
	class Sim_CORE_CFM_753 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack++;
						hc.addHp++;
						p.anzOwnExtraAngrHp += 2;
					}
				}
			}
			
        }
		
	}
}
