using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Lifesaving Aura
	//救生光环
	//At the end of your turn, get a 1-Cost Sunscreen that gives +1/+2. Lasts @ turns.
	//在你的回合结束时，获取一张法力值消耗为（1）的可以使随从获得+1/+2的防晒霜。持续@回合。
	class Sim_VAC_922 : SimTemplate
	{

        CardDB.cardIDEnum sunscreenCardID = CardDB.cardIDEnum.VAC_917t; // 假设防晒霜的卡牌ID为 VAC_917t

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 在每个回合结束时，获取防晒霜
            if (ownplay)
            {
                p.ownSunscreenTurns = 3; // 持续3回合的效果
            }
            else
            {
                p.enemySunscreenTurns = 3;
            }
        }

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            // 判断是否是触发玩家的回合结束
            if ((turnEndOfOwner && p.ownSunscreenTurns > 0) || (!turnEndOfOwner && p.enemySunscreenTurns > 0))
            {
                // 抽取防晒霜卡牌
                p.drawACard(sunscreenCardID, turnEndOfOwner, true);

                // 减少剩余回合数
                if (turnEndOfOwner)
                {
                    p.ownSunscreenTurns--;
                }
                else
                {
                    p.enemySunscreenTurns--;
                }
            }
        }
    }
}
