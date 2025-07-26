using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Supreme Archaeology
	//最最伟大的考古学
	//<b>Quest:</b> Draw 20 cards.<b>Reward:</b> Tome of Origination.
	//<b>任务：</b>抽20张牌。<b>奖励：</b>源生魔典。
	class Sim_ULD_140 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_140, questProgress = 0, maxProgress = 20 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_140, questProgress = 0, maxProgress = 20 };
        }
		
	}
}
