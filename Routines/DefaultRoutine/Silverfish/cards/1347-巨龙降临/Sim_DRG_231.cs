using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_231 : SimTemplate //* 光铸远征军 Lightforged Crusader
	{
		//[x]<b>Battlecry:</b> If your deckhas no Neutral cards,add 5 random Paladincards to your hand.
		//<b>战吼：</b>如果你的牌库中没有中立卡牌，随机将五张圣骑士卡牌置入你的手牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
			p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
			p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
			p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
			p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
		}
	}
}
