using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_356 : SimTemplate //* 滑翔 Glide
	{
		//[x]Shuffle your hand intoyour deck. Draw 4 cards.<b>Outcast:</b> Your opponentdoes the same.
		//将你的手牌洗入你的牌库，抽四张牌。<b>流放：</b>使你的对手做出相同行为。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{

			p.discardCards(10, ownplay);

			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			if (outcast)
			{
				p.evaluatePenality -= (p.enemyAnzCards - 4) * 10;
			}
		}
	}
}
