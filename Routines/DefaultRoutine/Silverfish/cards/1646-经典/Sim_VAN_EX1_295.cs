using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_295 : SimTemplate //* 寒冰屏障 Ice Block
//<b>Secret:</b> When your hero takes fatal damage, prevent it and become <b>Immune</b> this turn.
//<b>奥秘：</b>当你的英雄将要承受致命伤害时，防止这些伤害，并使其在本回合中获得<b>免疫</b>。 
	{
        

        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            target.Hp += number;
            target.immune = true;
        }

	}

}