using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_284 : SimTemplate //* 碧蓝幼龙 Azure Drake
//<b>Spell Damage +1</b><b>Battlecry:</b> Draw a card.
//<b>法术伤害+1</b>，<b>战吼：</b>抽一张牌。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
           
            p.drawACard(CardDB.cardIDEnum.None, own.own);
		}

        public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own)
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


	}
}