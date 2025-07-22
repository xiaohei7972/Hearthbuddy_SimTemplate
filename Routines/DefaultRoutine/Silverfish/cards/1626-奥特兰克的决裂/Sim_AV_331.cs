using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_331 : SimTemplate //* 纳亚克海克森 najakhexxen
	{
		//<b>战吼：</b>获得一个敌方随从的控制权。<b>亡语：</b>归还控制的随从。
        Minion Controlledminion;
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null) p.minionGetControlled(target, own.own, false);
            Controlledminion = target;
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.minionGetControlled(Controlledminion, !m.own, false);
            }
            else
            {
                foreach (Minion em in p.enemyMinions)
                {
                    if (em.enchs.Contains("AV_331e"))
                    {
                        p.minionGetControlled(em, m.own, false);
                        break;
                    }
                }
            }
        }
		
	}
}
