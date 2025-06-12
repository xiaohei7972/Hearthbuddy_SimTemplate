using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：7 攻击力：6 生命值：6
	//Endbringer Umbra
	//末日使者安布拉
	//[x]<b>Battlecry:</b> Trigger the<b>Deathrattles</b> of 5friendly minions thatdied this game.
	//<b>战吼：</b>触发本局对战中死亡的5个友方随从的<b>亡语</b>。
	class Sim_TLC_106 : SimTemplate
	{

		int i = 0;

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

			// 获取本局对战中的我方墓地
			// 判断是否有亡语
			// 如果有亡语就虚构随从触发亡语
			// 达到五次就结束
			foreach (KeyValuePair<CardDB.cardIDEnum, int> Graveyard in p.ownGraveyard)
			{
				CardDB.Card tmpCard = CardDB.Instance.getCardDataFromID(Graveyard.Key);
				if (tmpCard.deathrattle)
				{
					if (i == 5)
						break;
					// 创建一个虚拟随从来触发其亡语效果
						Minion minion = new Minion { handcard = new Handmanager.Handcard { card = tmpCard }, own = own.own };
					// 触发亡语效果
					tmpCard.sim_card.onDeathrattle(p, minion);
					i++;

				}
			}

		}



	}
}
