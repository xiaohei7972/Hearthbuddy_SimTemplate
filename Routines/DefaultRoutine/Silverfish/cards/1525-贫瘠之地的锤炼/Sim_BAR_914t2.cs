using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Imp Swarm (Rank 3)
	//小鬼集群（等级3）
	//Summon three 3/2 Imps.
	//召唤三个3/2的小鬼。
	class Sim_BAR_914t2 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_914t3);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
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
