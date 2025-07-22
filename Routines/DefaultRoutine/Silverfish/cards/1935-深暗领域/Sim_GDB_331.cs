using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_331 : SimTemplate // 分裂星岩 Splitting Spacerock
	{
		//<b>Deathrattle: Summon two 4/4 Splitting Boulders.
		//<b>亡语：召唤两个4/4的分裂块岩。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_331t1); // 分裂块岩

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own); // 召唤4/4分裂块岩
        }
	}
}
