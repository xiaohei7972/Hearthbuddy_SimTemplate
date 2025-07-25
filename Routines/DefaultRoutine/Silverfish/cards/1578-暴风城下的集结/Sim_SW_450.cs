using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//Sorcerer's Gambit
	//巫师的计策
	//<b>Questline:</b> Cast a Fire, Frost, and Arcane spell. <b>Reward: </b>Draw a spell.
	//<b>任务线：</b>施放火焰，冰霜和奥术法术各一个。<b>奖励：</b>抽一张法术牌。
	class Sim_SW_450 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_450, questProgress = 0, maxProgress = 3 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_450, questProgress = 0, maxProgress = 3 };
        }
		
	}
}
