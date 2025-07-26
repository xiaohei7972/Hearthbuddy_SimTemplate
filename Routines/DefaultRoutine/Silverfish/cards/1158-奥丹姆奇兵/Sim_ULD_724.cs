using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Activate the Obelisk
	//激活方尖碑
	//<b>Quest:</b> Restore 15_Health.<b>Reward:</b> Obelisk's Eye.
	//<b>任务：</b>恢复15点生命值。<b>奖励：</b>方尖碑之眼。
	class Sim_ULD_724 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_724, questProgress = 0, maxProgress = 15 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_724, questProgress = 0, maxProgress = 15 };
        }
		
	}
}
