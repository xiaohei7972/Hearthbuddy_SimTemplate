using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Unleash the Colossus
	//放出巨虫
	//<b>Quest:</b> Deal exactly 2 damage to an enemyon your turn, 12 times.<b>Reward:</b> Gorishi Colossus.
	//<b>任务：</b>在你的回合对敌人造成刚好2点伤害，总计12次。<b>奖励：</b>格里什巨虫。
	class Sim_TLC_631 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_631, questProgress = 0, maxProgress = 12 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_631, questProgress = 0, maxProgress = 12 };
		}
		
	}
}
