using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_102 : SimTemplate //* 工匠镇技师 Tinkertown Technician
//<b>Battlecry:</b> If you have a Mech, gain +1/+1 and add a <b>Spare Part</b> to your hand.
//<b>战吼：</b>如果你控制一个机械，便获得+1/+1并将一张<b>零件</b>牌置入你的手牌。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL)
                {
                    p.minionGetBuffed(own, 1, 1);
                    p.drawACard(CardDB.cardNameEN.armorplating, own.own, true);
                    return;
                }
            }
        }

    }

}