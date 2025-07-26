using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 拉卡利献祭 Lakkari Sacrifice
    //[x]<b>Quest:</b> Discard 6 cards.<b>Reward:</b> Nether Portal.
    //<b>任务：</b>弃掉六张牌。<b>奖励：</b>虚空传送门。 
    class Sim_UNG_829 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_829, questProgress = 0, maxProgress = 6 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.UNG_829, questProgress = 0, maxProgress = 6 };
        }
        
    }
}