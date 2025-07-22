using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_060 : SimTemplate //* 火鹰 Fire Hawk
	{
		//<b>Battlecry:</b> Gain +1 Attack for each card in your opponent's hand.
		//<b>战吼：</b>你的对手每有一张手牌，该随从便获得+1攻击力。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int anz = (own.own) ? p.enemyAnzCards : p.owncards.Count;
			if (anz >= 1)
			{
				p.minionGetBuffed(own, anz, 0);
			}
		}
		
	}
}
