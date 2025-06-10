using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：3 攻击力：2 生命值：4
	//Muscle-o-Tron
	//健身肌器人
	//[x]<b>Forged</b><b>Battlecry:</b> Give all minionsin your hand +2/+2.
	//<b>已锻造</b><b>战吼：</b>使你手牌中的所有随从牌获得+2/+2。
	class Sim_YOG_525t : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (hc.card.type == CardDB.cardtype.MOB)
				{
					hc.addattack += 2;
					hc.addHp += 2;
				}
			}
		}

	}
}
