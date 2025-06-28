using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 战士 费用：2
	//Clutch of Corruption
	//腐蚀之巢
	//[x]Choose a friendly Dragon.Summon a 0/2 Egg thathatches into a copy of it.
	//选择一条友方的龙。召唤一枚0/2的可以孵化成所选龙的复制的龙蛋。
	class Sim_EDR_454 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_454t);
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (target != null)
			{
				int pos = triggerMinion.own ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, triggerMinion.own);
				// Minion egg = new Minion { handcard = new Handmanager.Handcard { card = kid }, own = triggerMinion.own };
				// kid.sim_card.onDeathrattle(p, egg);
				p.ownMinions[pos - 1].deathrattle2 = kid;
			}
		}

		public override PlayReq[] GetUseAbilityReqs()
		{
			return new PlayReq[]
			{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE,24), // 只能是龙
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1),// 要求一个位置
            };
		}


	}
}
