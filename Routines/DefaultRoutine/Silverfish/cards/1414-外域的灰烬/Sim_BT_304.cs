using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_304 : SimTemplate //* 改进型恐惧魔王 Enhanced Dreadlord
	{
		//[x]<b>Taunt</b><b>Deathrattle:</b> Summon a 5/5Dreadlord with <b>Lifesteal</b>.
		//<b>嘲讽，亡语：</b>召唤一个5/5并具有<b>吸血</b>的恐惧魔王。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_304t);

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}

	}
}
