using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Barrel of Monkeys
	//一桶欢猢
	//Summon a 1/4 Monkey with <b>Taunt</b>.<i>(Last Monkey!)</i>
	//召唤一只1/4并具有<b>嘲讽</b>的猴子。<i>（最后一只猴子！）</i>
	class Sim_ETC_207t2 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_127);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需要一个空位
			};
		}
		
	}
}
