using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_413 : SimTemplate //* 脑力激荡者 Brainstormer
//[x]<b>Battlecry:</b> Gain +1 Healthfor each spell in your hand.
//<b>战吼：</b>你手牌中每有一张法术牌，便获得+1生命值。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, 0, (own.own) ? p.owncards.Count : p.enemyAnzCards);
		}


	}
}