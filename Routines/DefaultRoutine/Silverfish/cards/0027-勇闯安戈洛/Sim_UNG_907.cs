using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_907 : SimTemplate //* 欧泽鲁克 Ozruk
//[x]<b>Taunt</b><b>Battlecry:</b> Gain +5 Healthfor each Elemental youplayed last turn.
//<b>嘲讽，战吼：</b>在上个回合，你每使用一张元素牌，便获得+5生命值。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.minionGetBuffed(own, p.anzOwnElementalsLastTurn * 5, p.anzOwnElementalsLastTurn * 5);
		}
	}
}