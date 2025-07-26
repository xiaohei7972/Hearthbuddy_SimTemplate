using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：1
	//Corrupt the Waters
	//腐化水源
	//[x]<b>Quest:</b> Play 6 <b>Battlecry</b>cards.<b>Reward:</b> Heart of Vir'naal.
	//<b>任务：</b>使用6张<b>战吼</b>牌。<b>奖励：</b>维尔纳尔之心。
	class Sim_ULD_291 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_291, questProgress = 0, maxProgress = 6 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_291, questProgress = 0, maxProgress = 6 };
        }
		
	}
}
