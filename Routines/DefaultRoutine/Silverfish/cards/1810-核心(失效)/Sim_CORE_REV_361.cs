using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：3
	//Wild Spirits
	//野性之魂
	//[x]Summon two different <b>Dormant</b> Wildseeds. Make your Wildseeds awaken 1 turn sooner.
	//召唤两个不同的<b>休眠</b>灵种。使你的灵种提前1回合唤醒。
	class Sim_CORE_REV_361 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_360t);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_360t1);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid1, pos, ownplay);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1) // 最少需要一个空位
			};
		}
		
	}
}
