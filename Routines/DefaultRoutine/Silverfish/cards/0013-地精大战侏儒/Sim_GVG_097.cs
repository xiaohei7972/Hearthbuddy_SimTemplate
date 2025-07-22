using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_097 : SimTemplate //* 小个子驱魔者 Lil' Exorcist
//<b>Taunt</b><b>Battlecry:</b> Gain +1/+1 for each enemy <b>Deathrattle</b> minion.
//<b>嘲讽</b>，<b>战吼：</b>每有一个具有<b>亡语</b>的敌方随从，便获得+1/+1。 
    {

        
        
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.enemyMinions : p.ownMinions;

            int gain = 0;
            foreach (Minion m in temp)
            {
                if (m.handcard.card.deathrattle) gain++;
            }
            if(gain>=1) p.minionGetBuffed(own, gain, gain);
        }

      

    }

}