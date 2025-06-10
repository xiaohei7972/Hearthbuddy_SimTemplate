using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_035 : SimTemplate //* 玛洛恩 Malorne
//<b>Deathrattle:</b> Shuffle this minion into your deck.
//<b>亡语：</b>将该随从洗入你的牌库。 
    {

        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownDeckSize++;
            }
            else
            {
                p.enemyDeckSize++;
            }
        }


    }

}