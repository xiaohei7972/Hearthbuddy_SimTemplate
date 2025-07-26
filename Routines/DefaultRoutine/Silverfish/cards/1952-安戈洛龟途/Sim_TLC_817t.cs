using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Cleanse the Shadow
	//荡除暗影
	//[x]<b>Quest:</b> Cast 5 Holy spells.<b>Reward:</b> Life's Breath.
	//<b>任务：</b>施放5个神圣法术。<b>奖励：</b>生命之息。
	class Sim_TLC_817t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t, questProgress = 0, maxProgress = 4 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t, questProgress = 0, maxProgress = 4 };
		}
		
	}
}
