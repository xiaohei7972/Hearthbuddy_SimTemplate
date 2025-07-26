using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Corrupt the Light
	//污染光明
	//[x]<b>Quest:</b> Cast 5 Shadow spells.<b>Reward:</b> Death's Touch.
	//<b>任务：</b>施放5个暗影法术。<b>奖励：</b>死亡之触。
	class Sim_TLC_817t2 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t2, questProgress = 0, maxProgress = 4 };
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_817t2, questProgress = 0, maxProgress = 4 };

		}

	}
}
