using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_313 : SimTemplate //* 可怕的憎恶 hollowabomination
	{
		//<b>战吼：</b>对所有敌方随从造成1点伤害。<b>荣誉消灭：</b>获得目标随从的攻击力。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Minion m in p.enemyMinions)
            {
                p.minionSetLifetoX(m, 1);
                if (m.Hp == 1 && !m.divineshild)
                {
                    p.minionGetTempBuff(own, m.Angr, 0);
                }
            }
        }
		
	}
}
