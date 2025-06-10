using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_012 : SimTemplate //* 血法师萨尔诺斯 Bloodmage Thalnos
	{
		//<b>Spell Damage +1</b><b>Deathrattle:</b> Draw a card.
		//<b>法术伤害+1</b>，<b>亡语：</b>抽一张牌。
        public override void onAuraStarts(Playfield p, Minion own)
        {
           
            if (own.own)
            {
                p.spellpower++;
            }
            else
            {
                p.enemyspellpower++;
            }
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.spellpower--;
            }
            else
            {
                p.enemyspellpower--;
            }
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }

    }
}
