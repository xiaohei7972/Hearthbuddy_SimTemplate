using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Making Mummies
	//制作木乃伊
	//[x]<b>Quest:</b> Play 5 <b>Reborn</b>minions.<b>Reward:</b> Emperor Wraps.
	//<b>任务：</b>使用5张<b>复生</b>随从牌。<b>奖励：</b>帝王裹布。
	class Sim_ULD_431 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_326, questProgress = 0, maxProgress = 5 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_326, questProgress = 0, maxProgress = 5 };
        }
		
	}
}
