using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：5 生命值：5
	//Scrapbooking Student
	//游学生
	//<b>Battlecry:</b> Summon a copy of a friendly location.
	//<b>战吼：</b>召唤一个友方地标的复制。
	class Sim_VAC_529 : SimTemplate
	{
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// CardDB.ErrorType2.REQ_LOCATION_TARGET这个功能还没实现,因此还不能正确识别目标
			if (target != null)
			{
				if (p.ownMinions.Count < 6)
				{
					Minion minion = new Minion();
					p.callKid(target.handcard.card, own.zonepos, own.own);
					int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.ownMinions[pos - 1].setMinionToMinion(target);
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_LOCATION_TARGET), // 目标只能是地标
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没目标时也能用
			};
		}
		
	}
}
