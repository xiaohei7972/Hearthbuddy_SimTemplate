using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_008 : SimTemplate //* 锈誓新兵 Rustsworn Initiate
	{
		//<b>Deathrattle:</b> Summon a 1/1 Impcaster with<b>Spell Damage +1</b>.
		//<b>亡语：</b>召唤一个1/1并具有<b>法术伤害+1</b>的小鬼施法者。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_008t);

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own, false);
		}
	}
}
