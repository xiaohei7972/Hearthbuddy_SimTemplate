using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Hack the System
	//侵入系统
	//[x]<b>Quest:</b> Attack 5 timeswith your hero.<b>Reward:</b> Anraphet's Core.
	//<b>任务：</b>用你的英雄攻击5次。<b>奖励：</b>安拉斐特之核。
	class Sim_ULD_711 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 3) p.evaluatePenality -= 30;
            Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_711, questProgress = 0, maxProgress = 5 };
            p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.ULD_711, questProgress = 0, maxProgress = 5 };
        }
		
	}
}
