using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Final Showdown
	//一决胜负
	//<b>Questline:</b> Draw 4 cards in one turn. <b>Reward:</b> Reduce the Cost of the cards drawn by (1).
	//<b>任务线：</b>在一回合中抽四张牌。<b>奖励：</b>使抽到的牌法力值消耗减少（1）点。
	class Sim_SW_039 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_039, questProgress = 0, maxProgress = 4 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_039, questProgress = 0, maxProgress = 4 };
        }
		
	}
}
