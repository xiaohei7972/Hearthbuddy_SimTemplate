using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_310 : SimTemplate //* 虚灵神谕者 
	{
        //<b>Spell Damage +1</b> <b><b>Spellburst</b>:</b> Draw 2 spells.
        //<b>法术伤害+1</b> <b><b>法术迸发</b>：</b>抽两张法术牌。
        public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
        {
            if (m.own)
            {
                foreach (var cid in p.CheckTurnDeckForType(CardDB.cardtype.SPELL, 2))
                {
                    p.drawACard(cid, m.own);
                }
            }
        }

    }
}
