using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_311 : SimTemplate //* 黑暗曙光 A Light in the Darkness
//<b>Discover</b> a minion.Give it +1/+1.
//<b>发现</b>一张随从牌。使其获得+1/+1。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.lepergnome, ownplay, true);
            p.owncards[p.owncards.Count - 1].addattack++;
            p.owncards[p.owncards.Count - 1].addHp++;
        }
    }
}