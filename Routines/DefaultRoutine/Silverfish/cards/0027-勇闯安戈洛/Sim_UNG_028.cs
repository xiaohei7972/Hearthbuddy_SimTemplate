using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 打开时空之门 Open the Waygate
    //[x]<b>Quest:</b> Cast 8 spells thatdidn't start in your deck.<b>Reward:</b> Time Warp.
    //<b>任务：</b>施放8个你的套牌之外的法术。 <b>奖励：</b>时空扭曲。 
    class Sim_UNG_028 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_028, questProgress = 0, maxProgress = 8 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_028, questProgress = 0, maxProgress = 8 };
        }
        
    }
}