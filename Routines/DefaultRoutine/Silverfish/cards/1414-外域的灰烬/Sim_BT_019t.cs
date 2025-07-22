using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_019t : SimTemplate //* 终极莫戈尔格 Murgurgle Prime
	{
		//<b>Divine Shield</b><b>Battlecry:</b> Summon 4 random Murlocs. Give them <b>Divine Shield</b>.
		//<b>圣盾，战吼：</b>随机召唤四个鱼人。使它们获得<b>圣盾</b>。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_019t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos - 2, own.own);
			p.callKid(kid, own.zonepos - 1, own.own);
			p.callKid(kid, own.zonepos, own.own);
			p.callKid(kid, own.zonepos + 1, own.own);
		}
	}
}
