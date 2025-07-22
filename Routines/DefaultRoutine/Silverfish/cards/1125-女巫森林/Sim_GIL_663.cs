using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_663 : SimTemplate //* 女巫森林苹果 Witchwood Apple
//Add three 2/2 Treants to your hand.
//将三个2/2的树人置入你的手牌。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.treant, ownplay);
            p.drawACard(CardDB.cardNameEN.treant, ownplay);
            p.drawACard(CardDB.cardNameEN.treant, ownplay);
		}

	}
}