using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Rise to the Occasion
	//挺身而出
	//<b>Questline:</b> Play 3 different 1-Cost cards.<b>Reward:</b> Equip a 1/4 Light's Justice.
	//<b>任务线：</b>使用三张不同的法力值消耗为（1）的牌。<b>奖励：</b>装备一把1/4的圣光的正义。
	class Sim_SW_313 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_313, questProgress = 0, maxProgress = 3 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.SW_313, questProgress = 0, maxProgress = 3 };
        }
		
	}
}
