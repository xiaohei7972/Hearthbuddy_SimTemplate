using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_600 : SimTemplate //* 研发计划 Research Project
//Each player draws 2_cards.
//每个玩家抽两张牌。 
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, true);
            p.drawACard(CardDB.cardNameEN.unknown, true);
            p.drawACard(CardDB.cardNameEN.unknown, false);
            p.drawACard(CardDB.cardNameEN.unknown, false);

		}


	}
}