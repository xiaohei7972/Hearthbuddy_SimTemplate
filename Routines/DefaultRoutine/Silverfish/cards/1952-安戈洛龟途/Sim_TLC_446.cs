using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Escape the Underfel
	//逃离邪能地窟
	//<b>Quest:</b> Play 6 <b>Temporary</b> cards. <b>Reward:</b> Underfel Rift.
	//<b>任务：</b>使用6张<b>临时</b>牌。<b>奖励：</b>邪能地窟裂隙。
	class Sim_TLC_446 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_446, questProgress = 0, maxProgress = 5 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_446, questProgress = 0, maxProgress = 5 };
		}
		
	}
}
