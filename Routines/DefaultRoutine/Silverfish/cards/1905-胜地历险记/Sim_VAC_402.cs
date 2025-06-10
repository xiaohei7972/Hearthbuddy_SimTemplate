using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：3 攻击力：2 生命值：2
	//Frostbitten Freebooter
	//霜噬海盗
	//[x]<b><b>Deathrattle:</b> Freeze</b> 3random enemies. Anythat were already <b>Frozen</b> __take 5 damage instead.
	//<b>亡语：</b>随机<b>冻结</b>3个敌人，已被<b>冻结</b>的敌人改为受到5点伤害。
	class Sim_VAC_402 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> potentialTargets = new List<Minion>();
            potentialTargets.AddRange(p.enemyMinions);
            if (p.enemyHero != null) potentialTargets.Add(p.enemyHero);

            Random rng = new Random();
            for (int i = 0; i < 3; i++)
            {
                if (potentialTargets.Count == 0) break;

                // 从潜在目标中随机选择一个
                int randomIndex = rng.Next(potentialTargets.Count);
                Minion target = potentialTargets[randomIndex];

                if (target.frozen)
                {
                    // 如果目标已被冻结，则对其造成5点伤害
                    p.minionGetDamageOrHeal(target, 5);
                }
                else
                {
                    // 如果目标未被冻结，则将其冻结
                    target.frozen = true;
                }

                // 从列表中移除已处理的目标，避免重复处理
                potentialTargets.RemoveAt(randomIndex);
            }
        }

    }
}
