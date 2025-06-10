using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_051 : SimTemplate //* 禁忌古树 Forbidden Ancient
//<b>Battlecry:</b> Spend all your Mana. Gain +1/+1 for each Mana spent.
//<b>战吼：</b>消耗你所有的法力值，每消耗一点法力值，便获得+1/+1。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				p.minionGetBuffed(own, p.mana, p.mana);
				p.mana = 0;
			}
		}
	}
}