using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_507 : SimTemplate //* 失魂的守卫 Bewitched Guardian
//[x]<b>Taunt</b><b>Battlecry:</b> Gain +1 Health_for each card in your hand._
//<b>嘲讽，战吼：</b>你每有一张手牌，便获得+1生命值。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, 0, (own.own) ? p.owncards.Count : p.enemyAnzCards);
		}


	}
}