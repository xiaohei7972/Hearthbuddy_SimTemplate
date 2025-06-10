using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：3 攻击力：2 生命值：4
	//Muscle-o-Tron
	//健身肌器人
	//[x]<b>Battlecry:</b> Give all minionsin your hand +1/+1.<b>Forge:</b> +2/+2 instead.
	//<b>战吼：</b>使你手牌中的所有随从牌获得+1/+1。<b>锻造：</b>改为+2/+2。
	class Sim_YOG_525 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (hc.card.type == CardDB.cardtype.MOB)
				{
					hc.addattack += 1;
					hc.addHp += 1;
				}
			}
		}

	}
}
