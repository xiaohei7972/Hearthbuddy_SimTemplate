using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 丛林巨兽 Jungle Giants
    //[x]<b>Quest:</b> Summon5 minions with5 or more Attack.<b>Reward:</b> Barnabus.
    //<b>任务：</b>召唤5个攻击力大于或等于5的随从。<b>奖励：</b>班纳布斯。 
    class Sim_UNG_116 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_116, questProgress = 0, maxProgress = 5 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_116, questProgress = 0, maxProgress = 5 };
        }
    }
}