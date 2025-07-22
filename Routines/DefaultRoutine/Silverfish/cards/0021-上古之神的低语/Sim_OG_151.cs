using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_151 : SimTemplate //* 恩佐斯的触须 Tentacle of N'Zoth
//<b>Deathrattle:</b> Deal 1 damage to all minions.
//<b>亡语：</b>对所有随从造成1点伤害。 
	{
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionsGetDamage(1);
        }
	}
}