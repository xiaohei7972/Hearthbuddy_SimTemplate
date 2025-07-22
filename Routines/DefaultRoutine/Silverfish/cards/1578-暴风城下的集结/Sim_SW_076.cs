using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_076 : SimTemplate //* 城市建筑师 City Architect
	{
		//[x]<b>Battlecry:</b> Summon two0/5 Castle Wallswith <b>Taunt</b>.
		//<b>战吼：</b>召唤两个0/5并具有<b>嘲讽</b>的城堡石墙。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_076t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos, own.own);
			p.callKid(kid, own.zonepos+1, own.own);

		}
	}
}
