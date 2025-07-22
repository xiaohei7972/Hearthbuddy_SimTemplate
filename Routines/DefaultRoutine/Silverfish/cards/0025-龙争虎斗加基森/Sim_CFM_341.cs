using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_341 : SimTemplate //* 女警萨莉 Sergeant Sally
//<b>Deathrattle:</b> Deal damage equal to this minion's Attack to all enemy minions.
//<b>亡语：</b>对所有敌方随从造成等同于该随从攻击力的伤害。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionOfASideGetDamage(!m.own, m.Angr);
        }
    }
}