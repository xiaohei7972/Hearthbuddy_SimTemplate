using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_009 : SimTemplate //* 被禁锢的阳鳃鱼人 Imprisoned Sungill
	{
		//<b>Dormant</b> for 2 turns.When this awakens, summon two 1/1Murlocs.
		//<b>休眠</b>两回合。唤醒时，召唤两个1/1的鱼人。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_009t);
		public override void onDormantEndsTrigger(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos, m.own);
			p.callKid(kid, m.zonepos + 1, m.own);
		}

	}
}
