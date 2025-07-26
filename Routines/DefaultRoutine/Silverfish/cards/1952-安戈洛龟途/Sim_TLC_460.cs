using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//The Forbidden Sequence
	//禁忌序列
	//[x]<b>Quest:</b> <b>Discover</b> 8 cards.<b>Reward:</b> The Origin Stone.
	//<b>任务：</b><b>发现</b>8张牌。<b>奖励：</b>源生之石。
	class Sim_TLC_460 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_460, questProgress = 0, maxProgress = 8 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_460, questProgress = 0, maxProgress = 8 };
		}
		
	}
}
