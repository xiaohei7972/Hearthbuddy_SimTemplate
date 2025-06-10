using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_008 : SimTemplate //* 正义感召 Righteous Cause
	{
		//<b>Sidequest:</b> Summon 5 minions.<b>Reward:</b> Give your minions +1/+1.
		//<b>支线任务：</b>召唤五个随从。<b>奖励：</b>使你的随从获得+1/+1。
		public override void onQuestCompleteTrigger(Playfield p, bool own)
		{
			List<Minion> temp = own ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp) p.minionGetBuffed(m, 1, 1);
		}
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.DRG_008, questProgress = 0, maxProgress = 5 };
		}
	}
}