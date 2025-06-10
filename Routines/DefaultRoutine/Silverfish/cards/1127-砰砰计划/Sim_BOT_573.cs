using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_573 : SimTemplate //* 实验体9号 Subject 9
//<b>Battlecry:</b> Draw 5 different <b>Secrets</b> from your deck.
//<b>战吼：</b>从你的牌库中抽五张不同的<b>奥秘</b>牌。 
	{
		

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