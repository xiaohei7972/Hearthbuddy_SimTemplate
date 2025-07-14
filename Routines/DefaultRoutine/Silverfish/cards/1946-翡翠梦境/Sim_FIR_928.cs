using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：5 攻击力：5 生命值：5
	//Keeper of Flame
	//烈焰守护者
	//[x]<b>Battlecry:</b> Give all minionsin your hand +3/+3. Theyare destroyed in 3 turns.
	//<b>战吼：</b>使你手牌中的所有随从牌获得+3/+3，这些牌会在3回合后摧毁。
	class Sim_FIR_928 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack += 3;
						hc.addHp += 3;
						p.anzOwnExtraAngrHp += 6;
					}
				}
			}
			
		}

	}
}
