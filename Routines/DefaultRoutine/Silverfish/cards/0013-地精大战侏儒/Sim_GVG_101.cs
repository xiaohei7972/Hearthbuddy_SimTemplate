using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_101 : SimTemplate //* 血色净化者 Scarlet Purifier
//<b>Battlecry:</b> Deal 2 damage to all minions with <b>Deathrattle</b>.
//<b>战吼：</b>对所有具有<b>亡语</b>的随从造成2点伤害。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

            foreach (Minion m in p.ownMinions)
            {
                if (m.handcard.card.deathrattle && !m.silenced) p.minionGetDamageOrHeal(m, 2);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.handcard.card.deathrattle && !m.silenced) p.minionGetDamageOrHeal(m, 2);
            }
        }
    }
}