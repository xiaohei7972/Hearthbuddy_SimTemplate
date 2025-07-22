using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_240: SimTemplate //* 符文熔铸游魂 Runeforge Haunter
//During your turn, your weapon doesn't lose Durability.
//在你的回合时，你的武器不会失去耐久度。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.ownWeapon.immune = true;
            else p.enemyWeapon.immune = true;
        }

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                if (turnStartOfOwner) p.ownWeapon.immune = true;
                else p.enemyWeapon.immune = true;
            }
        }
    }
}