using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_305 : SimTemplate //* 秘密通道 Secret Passage
	{
        //Replace your hand with 5 cards from your deck. Swap back next turn.
        //将你的手牌替换为你牌库中的4张牌。下回合换回。

        private List<Handmanager.Handcard> originalHand = new List<Handmanager.Handcard>();
        private List<Handmanager.Handcard> newHand = new List<Handmanager.Handcard>();

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 保存当前手牌
            originalHand = new List<Handmanager.Handcard>(p.owncards);

            // 清空当前手牌
            p.owncards.Clear();

            // 从牌库中抽取4张新牌
            for (int i = 0; i < 4; i++)
            {
                p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
            }
            p.triggerCardsChanged(true);
            newHand = new List<Handmanager.Handcard>(p.owncards);
        }

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner)
            {
                // 丢弃在秘密通道中抽到的4张牌
                foreach (Handmanager.Handcard hc in newHand)
                {
                    p.removeCard(hc);
                }

                // 恢复原来的手牌
                p.owncards.AddRange(originalHand);

                // 清空临时手牌列表
                newHand.Clear();
            }
        }
    }
}
