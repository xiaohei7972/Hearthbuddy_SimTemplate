using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_807: SimTemplate //* 硬壳清道夫 Strongshell Scavenger
//<b>Battlecry:</b> Give your <b>Taunt</b> minions +2/+2.
//<b>战吼：</b>使你具有<b>嘲讽</b>的随从获得+2/+2。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp)
            {
                if (mnn.taunt) p.minionGetBuffed(mnn, 2, 2);
            }
        }
    }
}