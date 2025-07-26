using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 游园迷梦 Lost in the Park
    //<b>Questline:</b> Gain 4 Attack with your hero. <b>Reward:</b> Gain 5 Armor.
    //<b>任务线：</b>使你的英雄获得4点攻击力。<b>奖励：</b>获得5点护甲值。
    class Sim_SW_428 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_428, questProgress = 0, maxProgress = 4 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_428, questProgress = 0, maxProgress = 4 };
        }

    }
}
