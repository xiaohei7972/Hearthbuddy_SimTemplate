using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_CS2_011 : SimTemplate //savageroar
    {

        //    verleiht euren charakteren +2 angriff in diesem zug.
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion t in temp)
            {
                p.minionGetTempBuff(t, 2, 0);
            }
            if (p.ownHero.Angr == 0)
            {
                p.ownHero.Ready = true;
            }
            p.minionGetTempBuff(p.ownHero, 2, 0);            
        }

    }
}