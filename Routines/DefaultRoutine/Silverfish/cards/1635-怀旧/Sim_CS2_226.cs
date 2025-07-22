using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_226 : SimTemplate //* 霜狼督军 Frostwolf Warlord
	{
		//<b>Battlecry:</b> Gain +1/+1 for each other friendly minion on the battlefield.
		//<b>战吼：</b>战场上每有一个其他友方随从，便获得+1/+1。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int buff = (own.own) ? p.ownMinions.Count - 1 : p.enemyMinions.Count - 1;
            p.minionGetBuffed(own, buff, buff);
		}
	}
}