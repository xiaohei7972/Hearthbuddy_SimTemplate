using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 鱼人总动员 Unite the Murlocs
    //[x]<b>Quest:</b> Summon10 Murlocs.<b>Reward:</b> Megafin.
    //<b>任务：</b>召唤10个鱼人。<b>奖励：老鲨嘴</b>。 
    class Sim_UNG_942 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_942, questProgress = 0, maxProgress = 10 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_942, questProgress = 0, maxProgress = 10 };
        }
        
    }
}