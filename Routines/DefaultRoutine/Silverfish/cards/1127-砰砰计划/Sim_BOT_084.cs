using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_084 : SimTemplate //* 紫色烟雾 Violet Haze
//Add 2 random <b>Deathrattle</b> cards to_your hand.
//随机将两张<b>亡语</b>牌置入你的手牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
		}

	}
}