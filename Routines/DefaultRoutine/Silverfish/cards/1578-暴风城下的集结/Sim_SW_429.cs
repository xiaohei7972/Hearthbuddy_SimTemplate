using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_429 : SimTemplate //* 紧壳商品 Best in Shell
	{
		//[x]<b>Tradeable</b>Summon two 2/7_Turtles with <b>Taunt</b>.
		//<b>可交易</b>召唤两只2/7并具有<b>嘲讽</b>的龟。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_429t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
			p.callKid(kid, pos, ownplay);
		}
	}
}
