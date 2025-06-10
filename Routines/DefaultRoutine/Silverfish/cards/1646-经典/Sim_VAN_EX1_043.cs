using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_043 : SimTemplate //* 暮光幼龙 Twilight Drake
	{
		//<b>Battlecry:</b> Gain +1 Health for each card in your hand.
		//<b>战吼：</b>你每有一张手牌，便获得+1生命值。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, 0, (own.own) ? p.owncards.Count : p.enemyAnzCards);
		}


	}
}