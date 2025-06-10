using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_306 : SimTemplate //* 永恒祭司 Immortal Prelate
//<b>Deathrattle:</b> Shuffle this into your deck. It keeps any enchantments.
//<b>亡语：</b>将该随从洗入你的牌库。保留所有额外效果。 
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