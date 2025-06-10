using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
 	class Sim_VAN_EX1_584 : SimTemplate //* 年迈的法师 Ancient Mage
	{
		//<b>Battlecry:</b> Give adjacent_minions <b>Spell_Damage +1</b>.
		//<b>战吼：</b>使相邻的随从获得<b>法术伤害+1</b>。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
                {
                    m.spellpower++;
                    if (own.own)
                    {
                        p.spellpower++;
                    }
                    else
                    {
                        p.enemyspellpower++;
                    }
                }
            }
		}


	}
}