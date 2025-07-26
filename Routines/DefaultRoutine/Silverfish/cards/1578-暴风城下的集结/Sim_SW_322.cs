using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Defend the Dwarven District
	//保卫矮人区
	//<b>Questline:</b> Deal damage with 3 spells. <b>Reward:</b> Your Hero Power can target minions.
	//<b>任务线：</b>通过三张法术牌造成伤害。<b>奖励：</b>你的英雄技能能够以随从为目标。
	class Sim_SW_322 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_322, questProgress = 0, maxProgress = 3 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_322, questProgress = 0, maxProgress = 3 };
        }
		
	}
}
