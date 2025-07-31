using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Refresh the Tavern
	//刷新酒馆
	//<b>Discover</b> a 3-Cost minion. Refresh 3 Mana Crystals.
	//<b>发现</b>一张法力值消耗为（3）的随从牌。复原3个法力水晶。
	class Sim_BG31_BOBt3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
			if (ownplay)
			{
				p.mana = Math.Max(p.ownMaxMana, p.mana += 3);
			}
			else
			{
				// p.enemyMaxMana = Math.Max(p.enemyMaxMana, p.mana += 3);

			}
			
		}

	}
}
