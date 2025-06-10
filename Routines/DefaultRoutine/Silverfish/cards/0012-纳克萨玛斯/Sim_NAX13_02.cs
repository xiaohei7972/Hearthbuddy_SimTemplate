using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX13_02 : SimTemplate //* 极性转换 Polarity Shift
//<b>Hero Power</b>Swap the Attack and Health of all minions.
//<b>英雄技能</b>使所有随从的攻击力和生命值互换。 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
				p.minionSwapAngrAndHP(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
				p.minionSwapAngrAndHP(m);
            }
        }
    }
}