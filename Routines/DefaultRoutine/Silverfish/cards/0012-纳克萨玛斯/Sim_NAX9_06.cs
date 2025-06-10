using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX9_06 : SimTemplate //* 邪恶之影 Unholy Shadow
//<b>Hero Power</b>Draw 2 cards.
//<b>英雄技能</b>抽两张牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
	}
}