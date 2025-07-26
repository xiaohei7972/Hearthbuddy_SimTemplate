using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Lie in Wait
	//暗中设伏
	//[x]<b>Quest:</b> Shuffle cardsinto your deck, 5 times.<b>Reward: </b>Master Dusk.
	//<b>任务：</b>将卡牌洗入你的牌库，总计5次。<b>奖励：</b>暮影大师。
	class Sim_TLC_513 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_513, questProgress = 0, maxProgress = 5 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_513, questProgress = 0, maxProgress = 5 };
		}
		
	}
}
