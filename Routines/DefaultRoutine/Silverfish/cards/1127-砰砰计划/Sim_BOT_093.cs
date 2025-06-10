using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_093 : SimTemplate //* 元素反应 Elementary Reaction
//Draw a card. Copy it if_you played an Elemental last turn.
//抽一张牌。如果你在上个回合使用过元素牌，则复制抽到的牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            if (p.anzOwnElementalsLastTurn > 0 && ownplay) p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
		}
	}
}