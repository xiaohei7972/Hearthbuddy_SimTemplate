using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：5
	//Order the Orca
	//号令虎鲸
	//Summon a 6/6 Orca with <b>Taunt</b>.
	//召唤一只6/6并具有<b>嘲讽</b>的虎鲸。
	class Sim_TSC_650a : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_650t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需要一个空位
			};
		}

	}
}
