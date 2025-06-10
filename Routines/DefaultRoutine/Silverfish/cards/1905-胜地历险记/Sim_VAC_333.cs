using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：4 攻击力：4 生命值：4
	//Conniving Conman
	//蓄谋诈骗犯
	//<b>Battlecry:</b> Replay the last card you've played from a non-Rogue class.
	//<b>战吼：</b>再次使用你使用过的上一张非潜行者的职业牌。
	class Sim_VAC_333 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 获取最后一张职业牌的费用
            int lastCardCost = p.lastPlayedCardCost;

            if (lastCardCost >= 7)
            {
                p.evaluatePenality -= 15; // 如果最后一张职业牌的法力值消耗大于等于7，则减少惩罚
            }
            else
            {
                p.evaluatePenality += 15; // 如果最后一张职业牌的法力值消耗小于7，则增加惩罚
            }
        }
    }
}
