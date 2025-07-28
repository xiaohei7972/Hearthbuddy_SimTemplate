using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 无效的 费用：2
	//Starport
	//星港
	//[x]Summon a 2/1<b>Starship_Piece</b> with aneffect when launched.
	//召唤一个2/1并具有一项发射时效果的<b>星舰组件</b>。
	class Sim_SC_403 : SimTemplate
	{
		//星舰组件都放这了想随便用那个都可以,反正兄弟不好做随机计算
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_403a);
		// CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_403b);
		// CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_403c);
		// CardDB.Card kid3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_403d);
		// CardDB.Card kid4 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_403f);
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
				p.callKid(kid, triggerMinion.zonepos, triggerMinion.own);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
			};
		}
		//兄弟现在地标使用条件只有几个能用,写了也是白写
		// public override PlayReq[] GetUseAbilityReqs()
		// {
		// 	return new PlayReq[]{
		// 		new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
		// 	};
		// }


	}
}
