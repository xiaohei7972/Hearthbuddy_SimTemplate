using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：3 攻击力：4 生命值：3
	//Rock Master Voone
	//摇滚教父沃恩
	//<b>Battlecry:</b> Copy each minion of a different type in your hand.
	//<b>战吼：</b>复制你手牌中每个不同类型的随从牌各一张。
	class Sim_ETC_121 : SimTemplate
	{
		Dictionary<CardDB.Race, CardDB.Card> minionRace = new Dictionary<CardDB.Race, CardDB.Card>();
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					{
						// 判断卡牌是否有种族并且判断有种族的情况是否和其他卡牌的种族重复
						if (hc.card.race != CardDB.Race.BLANK && !minionRace.ContainsKey(hc.card.race))
						{
							// 将卡牌的种族和这种卡添加到集合
							minionRace.Add(hc.card.race, hc.card);
						}
					}
				}

				// 遍历种族集合复制手牌
				foreach (KeyValuePair<CardDB.Race, CardDB.Card> hcCard in minionRace)
				{
					if (!(p.owncards.Count == 10))
					{
						p.drawACard(hcCard.Value.nameEN, own.own, true);
					}
					else
					{
						break;
					}
				}
			}
		}

	}
}
