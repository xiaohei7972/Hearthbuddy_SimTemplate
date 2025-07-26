using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Reanimate the Terror
	//恐怖再起
	//[x]<b>Quest:</b> Spend 18 <b>Corpses</b>.<b>Reward:</b> Tyrax, Bone Terror.
	//<b>任务：</b>消耗18份<b>残骸</b>。<b>奖励：</b>泰拉克斯，魔骸暴龙。
	class Sim_TLC_433 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_433, questProgress = 0, maxProgress = 15 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_433, questProgress = 0, maxProgress = 15 };
		}
		
	}
}
