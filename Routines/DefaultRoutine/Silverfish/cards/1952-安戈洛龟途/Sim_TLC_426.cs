using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Dive the Golakka Depths
	//潜入葛拉卡
	//<b>Repeatable Quest:</b> Summon 5 Murlocs.<b>Reward:</b> Murlocs you summon gain +1/+1.
	//<b>可重复任务：</b>召唤5个鱼人。<b>奖励：</b>你召唤的鱼人获得+1/+1。
	class Sim_TLC_426 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_426, questProgress = 0, maxProgress = 5 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_426, questProgress = 0, maxProgress = 5 };
		}

		public override void onQuestCompleteTrigger(Playfield p, bool own)
		{
			// 鱼人任务得加个属性
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_426, questProgress = 0, maxProgress = 5 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_426, questProgress = 0, maxProgress = 5 };
		}

	}
}
