using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_255 : SimTemplate //* 雪落守护者 snowfallguardian
	{
        //<b>战吼：</b><b>冻结</b>所有其他随从。每<b>冻结</b>一个随从，便获得+1/+1。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetFrozen(m);
                p.minionGetBuffed(own, 1, 1);
            }
            foreach (Minion m in p.enemyMinions)
            {
                p.minionGetFrozen(m);
                p.minionGetBuffed(own, 1, 1);
            }
        }

    }
}
