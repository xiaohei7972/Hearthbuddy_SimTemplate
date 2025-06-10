using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_325 : SimTemplate //* 不死信徒 undyingdisciple
	{
		//<b>嘲讽</b>，<b>亡语：</b>对所有敌方随从造成等同于该随从攻击力的伤害。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int sh = m.Angr;
            foreach (Minion em in p.enemyMinions)
            {
                p.minionSetLifetoX(em, sh);
            }
        }
		
	}
}
