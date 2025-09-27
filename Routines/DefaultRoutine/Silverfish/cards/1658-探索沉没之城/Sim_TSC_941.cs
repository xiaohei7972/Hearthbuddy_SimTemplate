using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：2
	//Guard the City
	//保卫城市
	//Gain 3 Armor.Summon a 2/3 Naga with <b>Taunt</b>.
	//获得3点护甲值。召唤一个2/3并具有<b>嘲讽</b>的纳迦。
	class Sim_TSC_941 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_941t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero,3);
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
