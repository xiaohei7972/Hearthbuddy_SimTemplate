using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_042 : SimTemplate //* 始生保护者 Primordial Protector
	{
		//[x]<b>Battlecry:</b> Draw yourhighest Cost spell.Summon a random minionwith the same Cost.
		//<b>战吼：</b>抽取你法力值消耗最高的法术牌，随机召唤一个法力值消耗相同的随从。
		// TODO 写这个有点不值得了，先用惩罚
		// public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		// {
		// 	p.drawACard(CardDB.cardName.unknown, own.own);
		// 	// 要抽的卡
		// 	CardDB.cardName NameEnum = CardDB.cardName.unknown;
		// 	// 费用
		// 	int maxCost = 0;
		// 	// 遍历卡组
		// 	foreach(KeyValuePair<CardDB.cardIDEnum, int>kvp in p.prozis.turnDeck )
		// 	{
		// 		// ID 转卡
		// 		CardDB.cardIDEnum deckCard = kvp.Key;
		// 		CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
				
		// 	}
		// }
		
	}
}
