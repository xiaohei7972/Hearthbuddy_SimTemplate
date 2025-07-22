using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_581 : SimTemplate //* 缚沙者 Sandbinder
//<b>Battlecry:</b> Draw an Elemental from your deck.
//<b>战吼：</b>从你的牌库中抽一张元素牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}
	}
}