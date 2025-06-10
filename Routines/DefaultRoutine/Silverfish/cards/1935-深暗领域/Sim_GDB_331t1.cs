using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_331t1 : SimTemplate // 分裂块岩 Splitting Boulder
	{
		//<b>Deathrattle: Summon two 2/2 Splitting Stones.
		//<b>亡语：召唤两个2/2的分裂飞石。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_331t2); // 分裂飞石

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own); // 召唤2/2分裂飞石
        }
	}
}
