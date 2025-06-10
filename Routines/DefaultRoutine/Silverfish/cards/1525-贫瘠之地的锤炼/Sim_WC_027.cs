using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_027 : SimTemplate //* 吞噬软浆怪 Devouring Ectoplasm
	{
        //[x]<b>Deathrattle:</b> Summon a2/2 Adventurer with_a random bonus effect.
        //<b>亡语：</b>召唤一个2/2并具有随机效果的冒险者。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_034t2), m.zonepos, m.own);
        }

    }
}
