using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_735t : SimTemplate //* 奥的灰烬 Ashes of Al'ar
	{
        //At the start of your turn, transform this into Al'ar.
        //在你的回合开始时，该随从变形成为奥。
        public override void onAuraStarts(Playfield p, Minion m)
        {
            p.minionTransform(m, CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_735));
        }
    }
}
