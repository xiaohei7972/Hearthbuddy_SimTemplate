using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：1 生命值：1
	//Factory Assemblybot
	//工厂装配机
	//<b>Mini</b>At the end of your turn, summon a 6/7 Bot that attacks a random enemy.
	//<b>微型</b>在你的回合结束时，召唤一个6/7的机器人并使其攻击一个随机敌人。
	class Sim_TOY_601t : SimTemplate
	{
        private static Random rng = new Random(); // 创建一个静态的随机数生成器

        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 仅在随从所有者的回合结束时触发效果
            if (turnEndOfOwner == m.own)
            {
                if (p.ownMinions.Count < 7) // 确保场上有空位
                {
                    // 召唤一个 6/7 的机器人
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_601t2), p.ownMinions.Count, m.own); // 假设机器人的卡牌 ID 为 TOY_601t2
                    Minion bot = p.ownMinions[p.ownMinions.Count - 1];

                    // 随机选择一个敌方目标（包括敌方英雄）
                    List<Minion> possibleTargets = new List<Minion>(p.enemyMinions);
                    possibleTargets.Add(p.enemyHero);

                    if (possibleTargets.Count > 0)
                    {
                        int randomIndex = rng.Next(0, possibleTargets.Count); // 生成一个随机索引
                        Minion target = possibleTargets[randomIndex];
                        p.minionAttacksMinion(bot, target); // 机器人攻击选定的目标
                    }
                }
            }
        }

    }
}
