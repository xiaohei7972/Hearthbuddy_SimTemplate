using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_063 : SimTemplate //* 食人草 Biteweed
//<b>Combo:</b> Gain +1/+1 for each other card you've played this turn.
//<b>连击：</b>在本回合中，你每使用一张其他牌，便获得+1/+1。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int buff = own.own ? p.cardsPlayedThisTurn : p.enemyAnzCards;
            p.minionGetBuffed(own, buff, buff);
        }
    }
}
