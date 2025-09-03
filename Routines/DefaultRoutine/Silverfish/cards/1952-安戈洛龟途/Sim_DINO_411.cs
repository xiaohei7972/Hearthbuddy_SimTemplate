using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：2
	//Holy Eggbearer
	//神圣布蛋者
	//<b>Battlecry:</b> Draw a0-Attack minion.
	//<b>战吼：</b>抽一张攻击力为0的随从牌。
	class Sim_DINO_411 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card card = CardDB.Instance.getCardDataFromID(deckCard);
				// 检测卡牌是否为0攻
				if (card.type == CardDB.cardtype.MOB && card.Attack ==0)
				{
					p.drawACard(kvp.Key, own.own);
					break;
				}
			}
		}

	}
}
