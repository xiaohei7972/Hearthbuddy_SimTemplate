using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_023 : SimTemplate //* 黑市摊贩 Dark Peddler
//<b>Battlecry: Discover</b> a1-Cost card.
//<b>战吼：发现</b>一张法力值消耗为（1）的卡牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.lepergnome, own.own, true);
		}
	}
}