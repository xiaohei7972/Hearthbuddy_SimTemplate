using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_560 : SimTemplate //* 霸气的旅店老板娘 Heroic Innkeeper
//<b>Taunt.</b> <b>Battlecry:</b> Gain +2/+2 for each other friendly minion.
//<b>嘲讽，战吼：</b>每有一个其他友方随从，便获得+2/+2。 
	{
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int buff = (own.own) ? p.ownMinions.Count - 1 : p.enemyMinions.Count - 1;
            p.minionGetBuffed(own, buff*2, buff*2);
		}
	}
}