using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_320 : SimTemplate //* 午夜噩龙 Midnight Drake
//<b>Battlecry:</b> Gain +1 Attack for each other cardin your hand.
//<b>战吼：</b>你每有一张其它手牌，便获得+1攻击力。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, (own.own) ? p.owncards.Count : p.enemyAnzCards, 0);
		}
	}
}