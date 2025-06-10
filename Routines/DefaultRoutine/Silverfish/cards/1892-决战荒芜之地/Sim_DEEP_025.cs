using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：5
	//Shattered Reflections
	//破碎映像
	//Choose a non-<b>Titan</b>minion. Add a copy of it toyour deck and battlefield.
	//选择一个非<b>泰坦</b>随从，将一个它的复制置入你的牌库和战场。
	class Sim_DEEP_025 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null && !target.handcard.card.Titan) // 确保目标存在且不是泰坦
            {
                // 将随从的复制加入牌库
                // 增加牌库中卡牌的数量
                if (ownplay)
                {
                    p.ownDeckSize++;
                }
                else
                {
                    p.enemyDeckSize++;
                }

                // 将随从的复制直接召唤到战场
                p.callKid(target.handcard.card, target.zonepos, ownplay);
            }
        }
    }
}
