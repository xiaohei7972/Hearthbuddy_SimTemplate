using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_155 : SimTemplate //* 废料场巨像 Scrapyard Colossus
	{
		//[x]<b>Taunt</b><b>Deathrattle:</b> Summon a 7/7 Felcracked Colossuswith <b>Taunt</b>.
		//<b>嘲讽，亡语：</b>召唤一个7/7并具有<b>嘲讽</b>的邪爆巨像。
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_155t);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(card, m.zonepos - 1, m.own);
		}		
		
	}
}
