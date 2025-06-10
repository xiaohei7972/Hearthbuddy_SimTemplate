using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_039: SimTemplate //* 无面渗透者 Convincing Infiltrator
//[x]<b><b>Taunt</b></b><b>Deathrattle:</b> Destroy a random enemy minion.
//<b>嘲讽</b><b>亡语：</b>随机消灭一个敌方随从。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            Minion target = p.searchRandomMinion(m.own ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
            if (target != null) p.minionGetDestroyed(target);
        }
    }
}