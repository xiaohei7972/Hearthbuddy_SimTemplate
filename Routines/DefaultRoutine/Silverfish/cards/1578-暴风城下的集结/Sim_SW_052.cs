using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Find the Imposter
	//探查内鬼
	//<b>Questline:</b> Play 2SI:7 cards.<b>Reward:</b> Add a Spy Gizmo to your hand.
	//<b>任务线：</b>使用两张军情七处牌。<b>奖励：</b>将一张间谍小工具置入你的手牌。
	class Sim_SW_052 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_052, questProgress = 0, maxProgress = 2 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_052, questProgress = 0, maxProgress = 2 };
        }
		
	}
}
