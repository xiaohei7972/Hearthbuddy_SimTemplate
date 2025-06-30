using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：5
	//Figure in the Dark
	//暗处的身影
	//Summon two 3/6 Demons with <b>Taunt</b> that can't attack.
	//召唤两个3/6并具有<b>嘲讽</b>且无法攻击的恶魔。
	class Sim_EDR_490a : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_490t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, place, ownplay, false);
			p.callKid(kid, place, ownplay);
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需求选择一个目标

            };
		}
	}
}
