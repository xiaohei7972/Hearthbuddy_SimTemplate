using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：5
	//Romp of Otters
	//海獭欢游
	//Summon six 1/1 Otters with <b>Rush</b>.
	//召唤六只1/1并具有<b>突袭</b>的海獭。
	class Sim_TSC_650d : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_650d);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
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
