using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_151 : SimTemplate //* 白银之手骑士 Silver Hand Knight
	{
		//<b>Battlecry:</b> Summon a 2/2_Squire.
		//<b>战吼：</b>召唤一个2/2的侍从。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_CS2_152);//squire
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}

	}
}