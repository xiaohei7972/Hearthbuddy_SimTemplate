using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_214 : SimTemplate //* 闪避 Evasion
//<b>Secret:</b> After your hero takes damage, become <b>Immune</b> this turn.
//<b>奥秘：</b>你的英雄在受到伤害后，在本回合中获得<b>免疫</b>。 
	{
        

        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            if (p.ownHero.anzGotDmg > 0 )
			{
                target.immune = true;
			}
        }

	}

}