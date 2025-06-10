using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_076 : SimTemplate //* 自爆绵羊 Explosive Sheep
//<b>Deathrattle:</b> Deal 2 damage to all minions.
//<b>亡语：</b>对所有随从造成2点伤害。 
    {

        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionsGetDamage(2);
        }


    }

}