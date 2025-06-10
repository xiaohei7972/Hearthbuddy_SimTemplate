using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_877 : SimTemplate //* 逃生舱 
	{
        //[x]<b>Rush</b>  <b>Deathrattle:</b> Give adjacent  minions +1/+1 and <b>Rush</b>.
        //<b>突袭</b>。<b>亡语：</b> 使相邻的随从获得+1/+1和<b>突袭</b>。
        public override void onDeathrattle(Playfield p, Minion own)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
                {
                    p.minionGetBuffed(m, 1, 1);
                    p.minionGetRush(m);
                }
            }
        }
    }
}
