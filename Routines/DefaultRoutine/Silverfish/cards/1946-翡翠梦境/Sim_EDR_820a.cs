using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Encroaching Fear
	//渐近的恐惧
	//Summon two random <b>Dormant</b> Dreadseeds.
	//随机召唤两个<b>休眠</b>的魔种。
	class Sim_EDR_820a : SimTemplate
	{
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_840t1);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_840t2);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid1, pos, ownplay);
			p.callKid(kid2, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1) // 最少需要一个空位
			};
        }
	}
}
