using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 开进码头 Raid the Docks
    //[x]<b>Questline:</b> Play 3 Pirates.<b>Reward:</b> Draw a weapon.
    //<b>任务线：</b>使用三张海盗牌。<b>奖励：</b>抽一张武器牌。

    class Sim_SW_028 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_028, questProgress = 0, maxProgress = 3 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_028, questProgress = 0, maxProgress = 3 };
        }

    }
}
