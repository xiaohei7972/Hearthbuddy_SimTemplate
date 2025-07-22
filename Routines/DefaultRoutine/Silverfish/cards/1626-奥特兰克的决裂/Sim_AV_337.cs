using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_337 : SimTemplate //* 山岭野熊 mountainbear
	{
		//<b>嘲讽</b>，<b>亡语：</b>召唤两只2/4并具有<b>嘲讽</b>的山熊宝宝。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_337t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
		
	}
}
