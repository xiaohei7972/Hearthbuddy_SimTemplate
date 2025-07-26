using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：1
	//Untapped Potential
	//发掘潜力
	//[x]<b>Quest:</b> End 4 turnswith any unspent Mana.<b>Reward:</b> Ossirian Tear.
	//<b>任务：</b>在有未使用的法力水晶的情况下结束4个回合。<b>奖励：</b>奥斯里安之泪。
	class Sim_ULD_131 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_131, questProgress = 0, maxProgress = 4 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_131, questProgress = 0, maxProgress = 4 };
        }
		
	}
}
