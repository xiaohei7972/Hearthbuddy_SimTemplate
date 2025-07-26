using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 火羽之心 Fire Plume's Heart
    //[x]<b>Quest:</b> Play7 <b>Taunt</b> minions.<b>Reward:</b> Sulfuras.
    //<b>任务：</b>使用七张具有<b>嘲讽</b>的随从牌。<b>奖励：</b>萨弗拉斯。 
    class Sim_UNG_934 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_934, questProgress = 0, maxProgress = 7 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_934, questProgress = 0, maxProgress = 7 };
        }

    }
}