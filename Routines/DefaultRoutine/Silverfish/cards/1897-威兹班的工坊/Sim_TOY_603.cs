using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：3
	//Wreck'em and Deck'em
	//炮灰出动
	//[x]Choose a friendly Mech.Summon a copy of itthat attacks a randomenemy, then dies.
	//选择一个友方机械，召唤一个它的复制并使其攻击随机敌人然后死亡。
	class Sim_TOY_603 : SimTemplate
	{
        private static Random rng = new Random(); // 创建一个静态的随机数生成器

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 确保目标是一个友方机械随从
            if (target != null && target.own == ownplay && (TAG_RACE)target.handcard.card.race == TAG_RACE.MECHANICAL)
            {
                if (p.ownMinions.Count < 7) // 确保场上有空位
                {
                    // 召唤该机械随从的复制
                    p.callKid(target.handcard.card, p.ownMinions.Count, ownplay);
                    Minion copy = p.ownMinions[p.ownMinions.Count - 1];

                    // 随机选择一个敌方目标（包括敌方英雄）
                    List<Minion> possibleTargets = new List<Minion>(p.enemyMinions);
                    possibleTargets.Add(p.enemyHero);

                    if (possibleTargets.Count > 0)
                    {
                        int randomIndex = rng.Next(0, possibleTargets.Count); // 生成一个随机索引
                        Minion enemyTarget = possibleTargets[randomIndex];
                        p.minionAttacksMinion(copy, enemyTarget); // 复制体攻击选定的目标
                    }

                    // 攻击后立即死亡
                    p.minionGetDestroyed(copy);
                }
            }
        }
    }
}
