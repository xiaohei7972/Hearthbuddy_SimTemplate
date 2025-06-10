using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    // 随从 中立 费用：7 攻击力：5 生命值：6
    // Eredar Brute
    // 艾瑞达蛮兵
    // <b>Taunt</b>, <b>Lifesteal</b> Costs (1) less for each enemy minion.
    // <b>嘲讽</b>。<b>吸血</b> 每有一个敌方随从，本牌的法力值消耗便减少（1）点。
    class Sim_GDB_320 : SimTemplate
    {
        /*
        public int attack = 5;
        public int health = 6;
        public int cost = 7;

        // 计算卡牌的实际费用
        public void AdjustCostForEnemyMinions(Playfield p, Minion own)
        {
            int enemyMinionsCount = p.getEnemyMinions().Count;
            cost = Math.Max(0, 7 - enemyMinionsCount); // 每个敌方随从减少1点法力消耗
        }

        // 吸血效果实现
        public void ApplyLifesteal(Minion target)
        {
            // 吸血效果：每次攻击时恢复等于攻击力的生命值
            target.heal(attack);
        }

        // 处理嘲讽：在随从攻击时，设置它的嘲讽状态
        public void ApplyTaunt(Minion own)
        {
            own.taunt = true;
        }

        // 判断是否优先使用此卡牌
        public bool ShouldPlayCard(Playfield p, Minion own, int currentHealth, List<Card> handCards)
        {
            // 规则1：敌方场上随从数大于等于3时优先使用
            int enemyMinionsCount = p.getEnemyMinions().Count;
            if (enemyMinionsCount >= 3)
            {
                return true;
            }

            // 规则2：当自己血量低于15点时优先使用
            if (currentHealth < 15)
            {
                return true;
            }

            // 规则3：手里卡牌数量大于等于2，根据敌方随从数量判断
            if (handCards.Count >= 2)
            {
                // 可以根据敌方随从数量决定是否使用此卡牌
                if (enemyMinionsCount >= 2)
                {
                    return true; // 如果敌方有2个或更多随从，使用此卡牌
                }
            }

            // 默认情况下不使用此卡牌
            return false;
        }
        */
    }
}
