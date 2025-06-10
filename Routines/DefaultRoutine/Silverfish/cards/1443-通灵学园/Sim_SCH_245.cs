using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_245 : SimTemplate //* 卷轴管理者 Steward of Scrolls
	{
		//<b>Spell Damage +1</b><b>Battlecry:</b> <b>Discover</b> a spell.
		//<b>法术伤害+1</b><b>战吼：</b><b>发现</b>一张法术牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.thecoin, own.own, true);
		}

		public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own)
            {
                p.spellpower ++;
            }
            else
            {
                p.enemyspellpower ++;
            }
		}

		public override void onAuraEnds(Playfield p, Minion m)
        {

            if (m.own)
            {
                p.spellpower --;
            }
            else
            {
                p.enemyspellpower --;
            }
        }
	}
}
