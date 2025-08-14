using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：2
	//Unearthed Artifacts
	//出土神器
	//[x]Summon a random 2-Costminion. If you've <b><b>Discover</b>ed</b>this turn, summon a random4-Cost minion instead.
	//随机召唤一个法力值消耗为（2）的随从。如果你在本回合中<b><b>发现</b>过</b>，改为随机召唤一个法力值消耗为（4）的随从。
	class Sim_TLC_462 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_511); //目前召案卷书虫
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
