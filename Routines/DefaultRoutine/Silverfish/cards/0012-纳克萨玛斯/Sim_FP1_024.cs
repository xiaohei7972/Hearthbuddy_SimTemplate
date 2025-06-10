using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_024 : SimTemplate //* 蹒跚的食尸鬼 Unstable Ghoul
//<b>Taunt</b>. <b>Deathrattle:</b> Deal 1 damage to all minions.
//<b>嘲讽，亡语：</b>对所有随从造成1点伤害。 
	{



        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionsGetDamage(1);
        }


	}
}