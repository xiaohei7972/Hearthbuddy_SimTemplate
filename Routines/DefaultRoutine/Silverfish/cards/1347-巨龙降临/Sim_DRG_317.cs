using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_317 : SimTemplate //* 保护甲板 Secure the Deck
	{
        //<b>Sidequest:</b> Attack twice with your hero. <b>Reward:</b> Add 3 'Claw' spells to your hand.
        //<b>支线任务：</b>用你的英雄攻击两次。<b>奖励：</b>将三张“爪击”法术牌置入你的手牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.sideQuest.Id == CardDB.cardIDEnum.DRG_317)
            {
                p.evaluatePenality += 1000;
                return;
            }
            p.sideQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.DRG_317, questProgress = 0, maxProgress = 2 };
        }

    }
}
