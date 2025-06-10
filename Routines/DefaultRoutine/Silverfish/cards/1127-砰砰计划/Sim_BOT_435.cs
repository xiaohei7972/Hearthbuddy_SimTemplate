using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_435 : SimTemplate //* 克隆装置 Cloning Device
//<b>Discover</b> a copy of a minion in your opponent's deck.
//从你对手的牌库中<b>发现</b>一张随从牌的复制。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);           
		}
	}
}