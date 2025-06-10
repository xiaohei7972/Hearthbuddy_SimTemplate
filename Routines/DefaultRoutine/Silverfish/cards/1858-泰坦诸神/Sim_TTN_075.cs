using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：6 攻击力：3 生命值：8
	//Norgannon
	//诺甘农
	//<b>Titan</b>After this uses an ability, double the power of the other abilities.
	//<b>泰坦</b>在本随从使用一个技能后，其他技能的效果翻倍。
	class Sim_TTN_075 : SimTemplate
	{

        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            int skillUsedCount = 0;
            var targetMinions = p.ownMinions.Where(m => m.entitiyID == triggerMinion.entitiyID).ToList();
            targetMinions.ForEach(m =>
            {
                // 检查第一个技能是否已被使用
                if (m.handcard.card.TitanAbilityUsed1) skillUsedCount++;
                if (m.handcard.card.TitanAbilityUsed2) skillUsedCount++;
                if (m.handcard.card.TitanAbilityUsed3) skillUsedCount++;
            });
            switch (titanAbilityNO)
            {
                case 1: // 元尊之力
                    p.minionGetDamageOrHeal(target, 5 * (int)Math.Pow(2, skillUsedCount - 1)); // 对敌方随从造成5点伤害，伤害递增
                    break;

                case 2: // 远古知识
                    // 下个回合敌方卡牌的法力值消耗增加（1）点
                    // 实现具体逻辑
                    p.enemyMinions.ForEach(m => m.handcard.manacost += 1);
                    break;

                case 3: // 无限潜能
                    // 随机施放1个法师奥秘，假设模拟召唤法师奥秘
                    // 实现具体逻辑
                    p.drawACard(CardDB.cardIDEnum.None, triggerMinion.own, true);
                    break;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要随从目标
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 需要友方目标
            };
        }   


    }
}
