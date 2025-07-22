using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：5
	//Rumble Enthusiast
	//大作战狂热玩家
	//[x]After you play the left-or right-most card in yourhand, deal 1 damage toa random enemy.
	//在你使用最左或最右边的一张手牌后，随机对一个敌人造成1点伤害。
	class Sim_TOY_943 : SimTemplate
	{

        public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 仅当是己方卡牌被使用时触发效果
            if (wasOwnCard)
            {
                // 检查是否是手牌中最左或最右的卡牌
                if (p.owncards.Count > 0 && (card == p.owncards[0].card || card == p.owncards[p.owncards.Count - 1].card))
                {
                    // 随机对一个敌人造成1点伤害
                    p.allCharsOfASideGetRandomDamage(false, 1);
                }
            }
        }

    }
}
