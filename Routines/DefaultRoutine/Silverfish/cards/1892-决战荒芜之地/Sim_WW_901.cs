using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：3
	//Greedy Partner
	//贪婪的伴侣
	//<b>Battlecry:</b> If you're holding another 2-Cost card,get a Coin.
	//<b>战吼：</b>如果你手牌中有其他法力值消耗为2的牌，获取一张幸运币。
	class Sim_WW_901 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.owncards.Find(c => c.card.cost == 2) != null)
			{
				p.drawACard(CardDB.cardIDEnum.GAME_005, own.own);
			}
		}
	}
}
