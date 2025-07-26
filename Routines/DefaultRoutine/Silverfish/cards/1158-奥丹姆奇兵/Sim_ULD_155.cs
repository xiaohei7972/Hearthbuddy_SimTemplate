using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Unseal the Vault
	//打开宝库
	//<b>Quest:</b> Summon 20_minions.<b>Reward:</b> Pharaoh's Warmask.
	//<b>任务：</b>召唤20个随从。<b>奖励：</b>法老的面盔。
	class Sim_ULD_155 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_155, questProgress = 0, maxProgress = 20 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_155, questProgress = 0, maxProgress = 20 };
        }
		
	}
}
