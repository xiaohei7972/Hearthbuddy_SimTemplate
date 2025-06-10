using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_120 : SimTemplate //* 阿诺玛鲁斯 Anomalus
//<b>Deathrattle:</b> Deal 8 damage to all minions.
//<b>亡语：</b>对所有随从造成8点伤害。 
	{
		
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionsGetDamage(8);
        }
	}
}