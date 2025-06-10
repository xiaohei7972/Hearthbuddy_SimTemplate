using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_576 : SimTemplate //* 肯瑞托三修法师 Kirin Tor Tricaster
//<b>Spell Damage +3</b>Your spells cost (1) more.
//<b>法术伤害+3</b>你的法术牌法力值消耗增加（1）点。 
	{



        public override void onAuraStarts(Playfield p, Minion own)
		{
            p.ownSpelsCostMore += 1;
			if (own.own)
            {
                p.spellpower+=3;
            }
            else
            {
                p.enemyspellpower+=3;
            }
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.ownSpelsCostMore -= 1;
			if (m.own)
            {
                p.spellpower -= 3;
            }
            else
            {
                p.enemyspellpower -= 3;
            }
        }

	}
}