using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//Wolf's Strength
	//群狼的力量
	//Summon three 2/3 Wolves with <b>Taunt</b>.
	//召唤三只2/3并具有<b>嘲讽</b>的狼。
	class Sim_EDR_233a : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_tk11);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需求一个空位
            };
		}

	}
}
