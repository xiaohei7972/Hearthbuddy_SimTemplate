using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：4
	//Workshop Mishap
	//工坊事故
	//Deal $5 damage to a minion. Excess damages both neighbors.<b>Outcast:</b> Gain <b>Lifesteal</b>.
	//对一个随从造成$5点伤害，相邻的随从均会受到超过其生命值的伤害。<b>流放：</b>获得<b>吸血</b>。
	class Sim_TOY_640 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = 5;
            int excessDamage = damage - target.Hp;

            // 是否触发流放效果
            bool outcast = (ownplay && p.owncards.Count == 1) || (!ownplay && p.enemyAnzCards == 1);

            // 如果流放效果被触发，给该法术附加吸血属性
            if (outcast)
            {
                p.ownHero.immune = true;  // 表示吸血效果
            }

            // 对目标随从造成伤害
            p.minionGetDamageOrHeal(target, damage);

            // 如果有多余的伤害，分配给相邻的随从
            if (excessDamage > 0)
            {
                List<Minion> adjacentMinions = GetAdjacentMinions(p, target);
                foreach (Minion m in adjacentMinions)
                {
                    p.minionGetDamageOrHeal(m, excessDamage);
                }
            }

            // 如果有吸血效果，对英雄进行治疗
            if (outcast)
            {
                p.minionGetDamageOrHeal(p.ownHero, -damage);
            }
        }

        /// <summary>
        /// 获取目标随从的相邻随从
        /// </summary>
        /// <param name="p"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private List<Minion> GetAdjacentMinions(Playfield p, Minion target)
        {
            List<Minion> adjacentMinions = new List<Minion>();

            List<Minion> minions = target.own ? p.ownMinions : p.enemyMinions;

            int targetPos = minions.IndexOf(target);

            if (targetPos >= 0)
            {
                if (targetPos > 0)
                {
                    adjacentMinions.Add(minions[targetPos - 1]); // 左边的随从
                }
                if (targetPos < minions.Count - 1)
                {
                    adjacentMinions.Add(minions[targetPos + 1]); // 右边的随从
                }
            }

            return adjacentMinions;
        }
    }
}
