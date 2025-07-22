using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_211 : SimTemplate //* 猎风巨龙 Squallhunter
	{
		//<b>Spell Damage +2</b><b>Overload:</b> (2)
		//<b>法术伤害+2</b><b>过载：</b>（2）
		public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.spellpower++;
				p.spellpower++;
            }
            else
            {
                p.enemyspellpower++;
				p.enemyspellpower++;
            }
        }


        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.spellpower--;
				p.spellpower--;
            }
            else
            {
                p.enemyspellpower--;
				p.enemyspellpower--;
            }
        }
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay) p.ueberladung += 2;
		}

		
	}
}
