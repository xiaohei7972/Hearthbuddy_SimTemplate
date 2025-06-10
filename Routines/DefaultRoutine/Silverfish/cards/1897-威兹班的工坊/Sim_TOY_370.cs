using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TOY_370 : SimTemplate // Triple-Wick Candle
    {
        // <b>战吼：</b> 随机对一个敌人造成2点伤害，触发三次。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int totalDamage = 2;
            int triggerTimes = 3;

            List<Minion> enemyTargets = new List<Minion>(p.enemyMinions);

            if (p.enemyHero != null)
            {
                enemyTargets.Add(p.enemyHero);
            }

            // 如果没有敌方目标，直接返回
            if (enemyTargets.Count == 0)
            {
                return;
            }

            Random rand = new Random();

            for (int i = 0; i < triggerTimes; i++)
            {
                if (enemyTargets.Count > 0)
                {
                    Minion selectedTarget = enemyTargets[rand.Next(enemyTargets.Count)];
                    p.minionGetDamageOrHeal(selectedTarget, totalDamage);
                }
            }
        }
    }
}
