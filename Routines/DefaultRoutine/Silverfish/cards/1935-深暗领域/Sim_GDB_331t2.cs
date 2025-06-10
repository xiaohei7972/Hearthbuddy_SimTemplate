using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_331t2 : SimTemplate // 分裂飞石 Splitting Stone
	{
		//<b>Deathrattle: Summon two 1/1 Pebbles.
		//<b>亡语：召唤两个1/1的碎石。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_331t3); // 碎石

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own); // 召唤1/1碎石
        }
	}
}
