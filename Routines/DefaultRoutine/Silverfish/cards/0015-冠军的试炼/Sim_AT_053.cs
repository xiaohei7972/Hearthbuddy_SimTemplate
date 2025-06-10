using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_053 : SimTemplate //* 先祖知识 Ancestral Knowledge
//Draw 2 cards. <b>Overload:</b> (2)
//抽两张牌。<b>过载：</b>（2） 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
			if (ownplay) p.ueberladung += 2;
		}
	}
}