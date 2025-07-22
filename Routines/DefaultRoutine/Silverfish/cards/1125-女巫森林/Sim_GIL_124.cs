using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_124 : SimTemplate //* 苔藓恐魔 Mossy Horror
//<b>Battlecry:</b> Destroy all other_minions with 2_or_less_Attack.
//<b>战吼：</b>消灭所有其他攻击力小于或等于2的随从。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Minion m in p.enemyMinions)
            {
                if (m.Angr < 3) p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.ownMinions)
            {
                if (m.Angr < 3) p.minionGetDestroyed(m);
            }
        }
    }
}