using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_645 : SimTemplate //* 篝火元素 Bonfire Elemental
//<b>Battlecry:</b> If you played an_Elemental last turn, draw a card.
//<b>战吼：</b>如果你在上个回合使用过元素牌，抽一张牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.anzOwnElementalsLastTurn > 0 && own.own) p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}
	}
}