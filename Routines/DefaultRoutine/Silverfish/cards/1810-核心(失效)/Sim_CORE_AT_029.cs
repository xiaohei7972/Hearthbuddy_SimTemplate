using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 锈水海盗 Buccaneer
    //Whenever you equip a weapon, give it +1 Attack.
    //每当你装备一把武器，使武器获得+1攻击力。 
    class Sim_CORE_AT_029 : SimTemplate
    {
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.WEAPON)
            {
                p.ownWeapon.Angr++;
                p.minionGetBuffed(p.ownHero, 1, 0);
            }
        }

    }
}
