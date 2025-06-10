using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_855: SimTemplate //* 海德尼尔冰霜骑士 Hyldnir Frostrider
//<b>Battlecry:</b> <b>Freeze</b> your other minions.
//<b>战吼：</b><b>冻结</b>你的其他随从。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                p.minionGetFrozen(m);
            }
        }
    }
}