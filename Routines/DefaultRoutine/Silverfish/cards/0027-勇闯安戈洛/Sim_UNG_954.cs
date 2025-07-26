using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 最后的水晶龙 The Last Kaleidosaur
    //<b>Quest:</b> Cast 5 spellson your minions.<b>Reward:</b> Galvadon.
    //<b>任务：</b>对你的随从施放5个法术。<b>奖励：</b>嘉沃顿。
    class Sim_UNG_954 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_954, questProgress = 0, maxProgress = 5 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_954, questProgress = 0, maxProgress = 5 };
        }

    }
}