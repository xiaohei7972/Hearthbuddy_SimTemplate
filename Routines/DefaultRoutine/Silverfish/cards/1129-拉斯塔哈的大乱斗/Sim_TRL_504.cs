using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_504 : SimTemplate //* 藏宝海湾荷官 Booty Bay Bookie
//<b>Battlecry:</b> Give your opponent a Coin.
//<b>战吼：</b>使你的对手获得一个幸运币。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.thecoin, !own.own, true);
            if (own.own)
            {
                p.enemycarddraw -= 1;
            }
		}


	}
}