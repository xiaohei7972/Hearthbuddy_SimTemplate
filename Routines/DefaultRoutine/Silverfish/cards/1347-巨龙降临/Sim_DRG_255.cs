using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_255 : SimTemplate //* 病毒增援 Toxic Reinforcements
	{
		//[x]<b>Sidequest:</b> Use your HeroPower three times.<b>Reward:</b> Summon three1/1 Leper Gnomes.
		//<b>支线任务：</b>使用你的英雄技能三次。<b>奖励：</b>召唤三个1/1的麻风侏儒。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_029);
		public override void onQuestCompleteTrigger(Playfield p, bool own)
		{
			int pos = (own) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, own, false);
			p.callKid(kid, pos, own);
			p.callKid(kid, pos, own);
		}
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.DRG_255, questProgress = 0, maxProgress = 3 };
		}
	}
}