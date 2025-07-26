using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//Raid the Sky Temple
	//洗劫天空殿
	//<b>Quest:</b> Cast 10 spells.<b>Reward: </b>Ascendant Scroll.
	//<b>任务：</b>施放10个法术。<b>奖励：</b>升格卷轴。
	class Sim_ULD_433 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_433, questProgress = 0, maxProgress = 10 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_433, questProgress = 0, maxProgress = 10 };
        }
		
	}
}
