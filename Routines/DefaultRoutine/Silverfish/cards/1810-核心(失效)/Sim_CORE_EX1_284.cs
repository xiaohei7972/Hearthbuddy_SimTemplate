using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：4 生命值：5
	//Azure Drake
	//碧蓝幼龙
	//<b>Spell Damage +1</b><b>Battlecry:</b> Draw a card.
	//<b>法术伤害+1</b>，<b>战吼：</b>抽一张牌。
	class Sim_CORE_EX1_284 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None,own.own);
        }
		public override void onAuraStarts(Playfield p, Minion m)
		{
			if (m.own) p.spellpower += m.spellpower;
			else p.enemyspellpower += m.spellpower;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.spellpower -= m.spellpower;
            else p.enemyspellpower -= m.spellpower;
        }
		
	}
}
