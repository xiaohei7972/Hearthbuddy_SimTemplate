using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_938 : SimTemplate //* 暗影之门 Door of Shadows
//抽一张法术牌。注能（2）：将它的一张临时复制置入你的手牌。
//Draw a spell.Infuse (2): Add a temporary copy of it to your hand.
    {
        private int minionsDied = 0; // 记录当前已经死亡的随从数量

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽一张法术牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay);

            // 重置死亡随从计数器
            minionsDied = 0;
        }

        public override void onMinionDiedTrigger(Playfield p, Minion triggerEffectMinion, Minion diedMinion)
        {
            // 检查死亡的随从是否是友方随从
            if (diedMinion.own)
            {
                minionsDied++;

                // 检查注能条件（假设需要2个随从死亡）
                if (minionsDied >= 2)
                {
                    // 移除该卡牌并抽取衍生物牌（假设衍生物牌ID为RLK_567t）
                    for (int i = p.owncards.Count - 1; i >= 0; i--)
                    {
                        if (p.owncards[i].card.cardIDenum == CardDB.cardIDEnum.REV_938)
                        {
                            p.removeCard(p.owncards[i]);
                            p.drawACard(CardDB.cardIDEnum.REV_938t, true, true);
                            break;
                        }
                    }
                }
            }
        }
    }
}
