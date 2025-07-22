using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_242 : SimTemplate //* 迈拉的不稳定元素 Myra's Unstable Element
//Draw the rest ofyour deck.
//抽取你牌库剩下的牌。 
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
		}

	}
}