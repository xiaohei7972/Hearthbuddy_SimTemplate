using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_033 : SimTemplate //* 生命之树 Tree of Life
//Restore all characters to full Health.
//为所有角色恢复所有生命值。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			int heal = 1000;
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetDamageOrHeal(m, -heal);
            }
            foreach (Minion m in p.enemyMinions)
            {
                p.minionGetDamageOrHeal(m, -heal);
            }

            p.minionGetDamageOrHeal(p.enemyHero, -heal);
            p.minionGetDamageOrHeal(p.ownHero, -heal);
        }


    }

}