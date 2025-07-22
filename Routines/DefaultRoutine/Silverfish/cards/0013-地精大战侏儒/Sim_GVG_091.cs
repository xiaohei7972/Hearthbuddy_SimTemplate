using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_091 : SimTemplate //* 施法者克星X-21 Arcane Nullifier X-21
//<b>Taunt</b>Can't be targeted by spells or Hero Powers.
//<b>嘲讽，</b>无法成为法术或英雄技能的目标。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            own.cantBeTargetedBySpellsOrHeroPowers = true;
        }

    }

}