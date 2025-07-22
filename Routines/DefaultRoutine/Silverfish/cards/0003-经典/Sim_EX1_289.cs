using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_289 : SimTemplate //* 寒冰护体 Ice Barrier
	{
		//<b>Secret:</b> When yourhero is attacked,gain 8 Armor.
		//<b>奥秘：</b>当你的英雄受到攻击时，获得8点护甲值。
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            
            p.minionGetArmor(target, 8);
        }

	}

}