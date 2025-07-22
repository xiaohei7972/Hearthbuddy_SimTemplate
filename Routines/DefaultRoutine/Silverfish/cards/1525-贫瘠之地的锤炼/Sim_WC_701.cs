using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_701 : SimTemplate //* 邪能响尾蛇 Felrattler
	{
        //[x]<b>Rush</b><b>Deathrattle:</b> Deal 1 damageto all enemy minions.
        //<b>突袭</b>，<b>亡语：</b>对所有敌方随从造成1点伤害。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionOfASideGetDamage(!m.own, 1);
        }

    }
}
