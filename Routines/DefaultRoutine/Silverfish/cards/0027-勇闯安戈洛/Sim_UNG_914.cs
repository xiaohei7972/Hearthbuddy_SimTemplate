using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_914 : SimTemplate //* 迅猛龙宝宝 Raptor Hatchling
//<b>Deathrattle:</b> Shuffle a 4/3 Raptor into your deck.
//<b>亡语：</b>将一张4/3的“迅猛龙头领”洗入你的牌库。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own) p.ownDeckSize++;
            else p.enemyDeckSize++;
        }
    }
}