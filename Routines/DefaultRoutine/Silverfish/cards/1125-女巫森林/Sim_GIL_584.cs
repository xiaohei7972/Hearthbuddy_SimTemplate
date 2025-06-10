using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_584 : SimTemplate //* 女巫森林吹笛人 Witchwood Piper
//[x]<b>Battlecry:</b> Draw the lowestCost minion from your deck.
//<b>战吼：</b>从你的牌库中抽一张法力值消耗最低的随从牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}
	}
}