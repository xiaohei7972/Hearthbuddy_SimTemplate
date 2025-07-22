using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_920t2 : SimTemplate //* 卡纳莎的族群 Carnassa's Brood
//<b>Battlecry:</b> Draw a card.
//<b>战吼：</b>抽一张牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
		}
	}
}