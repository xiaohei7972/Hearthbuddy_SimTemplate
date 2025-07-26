using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：1
	//Command the Elements
	//号令元素
	//[x]<b>Questline:</b> Play 3 cards with <b>Overload</b>.<b>Reward:</b> Unlock your<b>Overloaded</b> Mana Crystals.
	//<b>任务线：</b>使用三张<b>过载</b>牌。<b>奖励：</b>解锁你<b>过载</b>的法力水晶。
	class Sim_SW_031 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_031, questProgress = 0, maxProgress = 3 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_031, questProgress = 0, maxProgress = 3 };
        }
		
	}
}
