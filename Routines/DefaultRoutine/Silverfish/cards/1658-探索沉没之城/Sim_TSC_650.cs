using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：5
	//Flipper Friends
	//划水好友
	//[x]<b>Choose One</b> - Summon a6/6 Orca with <b>Taunt</b>; orsix 1/1 Otters with <b>Rush</b>.
	//<b>抉择：</b>召唤一只6/6并具有<b>嘲讽</b>的虎鲸；或者六只1/1并具有<b>突袭</b>的海獭。
	class Sim_TSC_650 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_650t);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_650t4);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || p.ownFandralStaghelm  > 0)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
			}
			if (choice == 2 || p.ownFandralStaghelm  > 0)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid1, pos, ownplay);
				p.callKid(kid1, pos, ownplay);
				p.callKid(kid1, pos, ownplay);
				p.callKid(kid1, pos, ownplay);
				p.callKid(kid1, pos, ownplay);
				p.callKid(kid1, pos, ownplay);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需要一个空位
			};
		}

	}
}
