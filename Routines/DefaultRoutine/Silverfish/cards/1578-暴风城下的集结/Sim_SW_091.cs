using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 恶魔之种 The Demon Seed
	//[x]<b>Questline:</b> Take 8damage on your turns.<b>Reward:</b> <b>Lifesteal</b>. Deal $3damage to the enemy hero.
	//<b>任务线：</b>在你的回合中受到8点伤害。<b>奖励：</b><b>吸血</b>。对敌方英雄造成$3点伤害。
	class Sim_SW_091 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_091, questProgress = 0, maxProgress = 12 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_091, questProgress = 0, maxProgress = 12 };
        }

	}
}
