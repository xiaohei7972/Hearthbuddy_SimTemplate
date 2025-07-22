using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_069 : SimTemplate //* 老式治疗机器人 Antique Healbot
//<b>Battlecry:</b> Restore #8 Health to your hero.
//<b>战吼：</b>为你的英雄恢复#8点生命值。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                int heal = p.getMinionHeal(8);
                p.minionGetDamageOrHeal(p.ownHero, -heal, true);
            }
            else
            {
                int heal = p.getEnemyMinionHeal(8);
                p.minionGetDamageOrHeal(p.enemyHero, -heal, true);
            }
        }

    }

}