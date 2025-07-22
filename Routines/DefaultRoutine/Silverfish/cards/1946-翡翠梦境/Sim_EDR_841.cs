using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：4 攻击力：4 生命值：4
	//Dreadsoul Corrupter
	//恐魂腐蚀者
	//[x]<b>Battlecry and Deathrattle:</b>Summon a random<b>Dormant</b> Dreadseed.
	//<b>战吼，亡语：</b>随机召唤一个<b>休眠</b>的魔种。
	class Sim_EDR_841 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_840t1);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos, own.own);
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 2) // 最少需要两个空位
			};
		}

	}
}
