using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Reach Equilibrium
	//寻求平衡
	//[x]<b>Quest:</b> Cast 5 Holy spells<b>Reward:</b> Life's Breath.<b>Quest:</b> Cast 5 Shadow spells.<b>Reward:</b> Death's Touch.
	//<b>任务：</b>施放5个神圣法术。<b>奖励：</b>生命之息。<b>任务：</b>施放5个暗影法术。<b>奖励：</b>死亡之触。
	class Sim_TLC_817 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t, questProgress = 0, maxProgress = 4 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t, questProgress = 0, maxProgress = 4 };
			// 兄弟的任务结构有问题,只能处理一个任务,双任务或多任务得改结构
			// p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t2, questProgress = 0, maxProgress = 4 };
			// Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t2, questProgress = 0, maxProgress = 4 };

		}
		
	}
}
