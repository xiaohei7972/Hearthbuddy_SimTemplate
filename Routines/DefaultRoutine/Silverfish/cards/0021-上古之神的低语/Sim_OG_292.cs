using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_292 : SimTemplate //* 狼人追猎者 Forlorn Stalker
//<b>Battlecry:</b> Give all <b>Deathrattle</b> minions in your hand +1/+1.
//<b>战吼：</b>使你手牌中所有<b>亡语</b>随从牌获得+1/+1。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.deathrattle)
                    {
                        hc.addattack++;
                        hc.addHp++;
                    }
                }
            }
        }
    }
}