using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：7
	//Immortalized in Stone
	//永存石中
	//Summon a 4/8, 2/4, and 1/2 Elemental with <b>Taunt</b>.
	//召唤具有<b>嘲讽</b>的4/8，2/4，1/2的元素各一个。
	class Sim_CORE_TSC_076 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_076t3);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_076t2);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_076t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid1, pos, ownplay);
			p.callKid(kid2, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需要一个空位
			};
        }
		
	}
}
