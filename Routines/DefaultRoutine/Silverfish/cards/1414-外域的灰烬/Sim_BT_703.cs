using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_703 : SimTemplate //* 被诅咒的流浪者 Cursed Vagrant
	{
		//<b>Deathrattle:</b> Summon a 7/5 Shadow with <b>Stealth</b>.
		//<b>亡语：</b>召唤一个7/5并具有<b>潜行</b>的阴影。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_703t);

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}

	}
}
