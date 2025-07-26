using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Bazaar Burglary
	//劫掠集市
	//[x]<b>Quest:</b> Add 4 cards fromother classes to your hand.<b>Reward: </b>Ancient Blades.
	//<b>任务：</b>将4张其他职业的卡牌置入你的手牌。<b>奖励：</b>远古刀锋。
	class Sim_ULD_326 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_326, questProgress = 0, maxProgress = 4 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_326, questProgress = 0, maxProgress = 4 };
        }
		
	}
}
