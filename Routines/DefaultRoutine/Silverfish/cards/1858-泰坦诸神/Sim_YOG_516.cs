using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：9 攻击力：7 生命值：5
	//Yogg-Saron, Unleashed
	//脱困古神尤格-萨隆
	//[x]<b>Titan</b>After this uses an ability,cast two random spells.
	//<b>泰坦</b>在本随从使用一个技能后，随机施放两个法术。
	class Sim_YOG_516 : SimTemplate
	{
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 混沌统治
                    if (target != null)
                    {
                        p.minionGetControlled(target, true, true, true); // 夺取一个敌方随从的控制权
                    }
                    break;

                case 2: // 诱引狂乱
                    p.RandomEnemyMinionsAttackEachOther(); // 让每个敌方随从随机攻击一个敌方随从
                    break;

                case 3: // 触须攒聚
                    int cardCount = 10 - p.owncards.Count;
                    if (cardCount > 0)
                    {
                        for (int i = 0; i < cardCount; i++)
                        {
                            p.drawACard(CardDB.cardIDEnum.YOG_514, true); // 用1/1的混乱触须填满手牌
                        }
                    }
                    break;

            }
        }

    }
}
