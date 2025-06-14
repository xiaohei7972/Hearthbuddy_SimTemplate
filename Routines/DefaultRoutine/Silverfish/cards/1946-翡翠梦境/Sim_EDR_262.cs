using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：3
	//Spirit Bond
	//灵魂联结
	//Deal $3 damageto a minion.If that kills it, summon a3/2 Wolf with <b>Rush</b>.
	//对一个随从造成$3点伤害。如果消灭该随从，召唤一只3/2并具有<b>突袭</b>的狼。
	class Sim_EDR_262 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_850pe);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.minionGetDamageOrHeal(target, 3);
			if (target.Hp <= 0) p.callKid(kid, pos, ownplay);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从
			};
		}

	}
}
