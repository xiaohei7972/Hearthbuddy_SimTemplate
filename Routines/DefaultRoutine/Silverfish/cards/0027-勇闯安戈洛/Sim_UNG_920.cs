using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 湿地女王 The Marsh Queen
    //[x]<b>Quest:</b> Play seven1-Cost minions.<b>Reward:</b> Queen Carnassa.
    //<b>任务：</b>使用七张法力值消耗为（1）的随从牌。<b>奖励：</b>卡纳莎女王。 
    class Sim_UNG_920 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_920, questProgress = 0, maxProgress = 7 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_920, questProgress = 0, maxProgress = 7 };
        }

    }
}