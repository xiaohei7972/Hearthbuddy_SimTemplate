using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Enter the Lost City
	//走进失落之城
	//[x]<b>Quest:</b> Survive 10 turns.<b>Reward: </b>Latorvius, Gazeof the City.
	//<b>任务：</b>存活10个回合。<b>奖励：</b>拉特维厄斯，城市之眼。
	class Sim_TLC_602 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_602, questProgress = 0, maxProgress = 10 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_602, questProgress = 0, maxProgress = 10 };
		}
		
	}
}
