using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_735 : SimTemplate //* 奥 Al'ar
	{
        //<b>Deathrattle</b>: Summon a 0/3 Ashes of Al'ar that resurrects this minion on your next turn.
        //<b>亡语：</b>召唤一个0/3的可以在你的下个回合复活该随从的“奥的灰烬”。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_735t),m.zonepos - 1, m.own);
        }

    }
}
