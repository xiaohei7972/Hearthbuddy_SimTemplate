using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_211 : SimTemplate //* 凶恶霜狼 direfrostwolf
	{
		//<b>潜行</b>，<b>亡语：</b> 召唤一只2/2并具有<b>潜行</b>的狼。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_211t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
	}
}
