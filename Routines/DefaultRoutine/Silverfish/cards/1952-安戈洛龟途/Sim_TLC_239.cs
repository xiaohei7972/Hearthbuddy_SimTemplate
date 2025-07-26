using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：1
	//Restore the Wild
	//治愈荒野
	//<b>Quest:</b> Fill your boardon 3 of your turns.<b>Reward:</b> The Everbloom.
	//<b>任务：</b>填满你的面板，总计3回合。<b>奖励：</b>永茂之花。
	class Sim_TLC_239 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_239, questProgress = 0, maxProgress = 3 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_239, questProgress = 0, maxProgress = 3 };
		}
		
	}
}
