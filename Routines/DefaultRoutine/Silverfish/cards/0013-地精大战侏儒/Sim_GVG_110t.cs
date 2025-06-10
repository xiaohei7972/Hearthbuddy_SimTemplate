using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_110t : SimTemplate //* 砰砰机器人 Boom Bot
//<b>Deathrattle:</b> Deal 1-4 damage to a random enemy.
//<b>亡语：</b>随机对一个敌人造成1-4点伤害。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> temp = (m.own) ? p.enemyMinions : p.ownMinions;
            Minion target = p.searchRandomMinion(temp, searchmode.searchHighestHP);
            if (target == null) target = (m.own) ? p.enemyHero : p.ownHero;
            p.minionGetDamageOrHeal(target, 2);
        }
    }
}