using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：1
	//Spirit of the Mountain
	//群山之灵
	//<b>Quest:</b> Play 7 minionsof unique types.<b>Reward:</b> Ashalon.
	//<b>任务：</b>使用7个不同类型的随从牌。<b>奖励：</b>阿沙隆。
	class Sim_TLC_229 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.playactions.Count < 3) p.evaluatePenality -= 30;
			p.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_229, questProgress = 0, maxProgress = 6 };
			Questmanager.Instance.ownQuest = new Questmanager.QuestItem() { Id = CardDB.cardIDEnum.TLC_229, questProgress = 0, maxProgress = 6 };
		}
		
	}
}
