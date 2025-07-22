using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_303 : SimTemplate //* 异教女巫 Cult Sorcerer
//[x]<b><b>Spell Damage</b> +1</b>After you cast a spell,give your C'Thun +1/+1<i>(wherever it is).</i>
//<b>法术伤害+1</b>在你施放一个法术后，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i> 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (m.own == ownplay && hc.card.type == CardDB.cardtype.SPELL) p.cthunGetBuffed(1, 1, 0);
        }
		
        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.spellpower++;
            else p.enemyspellpower++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.spellpower--;
            else p.enemyspellpower--;
        }
	}
}