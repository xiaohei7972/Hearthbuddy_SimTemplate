using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 唤醒造物者 Awaken the Makers
    //<b>Quest:</b> Summon7 <b>Deathrattle</b> minions.<b>Reward:</b> Amara, Warden of Hope.
    //<b>任务：</b>召唤7个具有<b>亡语</b>的随从。<b>奖励：</b>希望守护者阿玛拉。 
    class Sim_UNG_940 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_940, questProgress = 0, maxProgress = 7 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_940, questProgress = 0, maxProgress = 7 };
        }

    }
}