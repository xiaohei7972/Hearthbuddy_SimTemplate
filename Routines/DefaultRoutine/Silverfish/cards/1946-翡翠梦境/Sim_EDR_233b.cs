using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//Falcon's Dexterity
	//猎鹰的灵动
	//Summon two 4/3 Falcons with <b>Windfury</b>.
	//召唤两只4/3并具有<b>风怒</b>的猎鹰。
	class Sim_EDR_233b : SimTemplate
	{
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_233t2);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid1, pos, ownplay);
			p.callKid(kid1, pos, ownplay);

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需求一个空位
            };
		}

	}
}
