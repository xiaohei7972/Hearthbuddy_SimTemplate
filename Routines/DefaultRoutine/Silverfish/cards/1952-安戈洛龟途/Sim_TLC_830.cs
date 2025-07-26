using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//The Food Chain
	//食物链
	//<b>Quest:</b> Play a 1, 3, 5, and 7-Attack Beast.<b>Reward:</b> Shokk.
	//<b>任务：</b>使用攻击力为1，3，5，7的野兽牌各一张。<b>奖励：</b>绍克。
	class Sim_TLC_830 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_830, questProgress = 0, maxProgress = 4 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_830, questProgress = 0, maxProgress = 4 };
			
		}

	}
}
