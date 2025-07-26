using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 探索地下洞穴 The Caverns Below
    // //[x]<b>Quest:</b> Play four minionswith the same name.<b>Reward:</b> Crystal Core.
    //<b>任务：</b>使用四张名称相同的随从牌。<b>奖励：</b>水晶核心。
    class Sim_UNG_067 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_067, questProgress = 0, maxProgress = 4 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_067, questProgress = 0, maxProgress = 4 };
        }
    
    }
}
