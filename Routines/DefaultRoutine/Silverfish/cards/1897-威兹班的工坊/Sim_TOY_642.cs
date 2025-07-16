using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 恶魔猎手 费用：4 攻击力：3 生命值：3
    //Ball Hog
    //球霸野猪人
    //[x]<b>Lifesteal</b><b>Battlecry and Deathrattle:</b>Deal 3 damage to thelowest Health enemy.
    //<b>吸血</b>。<b>战吼，亡语：</b>对生命值最低的敌人造成3点伤害。
    class Sim_TOY_642 : SimTemplate
    {

        // 战吼效果
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> minions = own.own ? p.enemyMinions : p.ownMinions;
            if (own.own)
            {
                minions.Add(p.enemyHero);
            }
            else
            {
                minions.Add(p.ownHero);
            }
            Minion targetMinion = p.searchRandomMinion(minions, searchmode.searchLowestHP);

            if (targetMinion != null)
            {
                p.minionGetDamageOrHeal(targetMinion, 3);
            }
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -3);

        }

        // 亡语效果
        public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> minions = m.own ? p.enemyMinions : p.ownMinions;
            if (m.own)
            {
                minions.Add(p.enemyHero);
            }
            else
            {
                minions.Add(p.ownHero);
            }
            Minion targetMinion = p.searchRandomMinion(minions, searchmode.searchLowestHP);

            if (targetMinion != null)
            {
                p.minionGetDamageOrHeal(targetMinion, 3);
            }
            p.minionGetDamageOrHeal(m.own ? p.ownHero : p.enemyHero, -3);

        }


    }
}
