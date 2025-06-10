using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_613 : SimTemplate //* 艾德温·范克里夫 Edwin VanCleef
	{
		//<b>Combo:</b> Gain +2/+2 for each other card you've played this turn.
		//<b>连击：</b>在本回合中，你每使用一张其他牌，便获得+2/+2。
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

            if(own.own) p.minionGetBuffed(own, p.cardsPlayedThisTurn * 2, p.cardsPlayedThisTurn * 2);
            else p.minionGetBuffed(own, p.enemyAnzCards * 2, p.enemyAnzCards * 2);
        }

    }
}
