using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_115 : SimTemplate //* 托什雷 Toshley
//<b>Battlecry and Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
//<b>战吼，亡语：</b>将一张<b>零件</b>牌置入你的手牌。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.armorplating, own.own, true);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.armorplating, m.own, true);
        }


    }

}