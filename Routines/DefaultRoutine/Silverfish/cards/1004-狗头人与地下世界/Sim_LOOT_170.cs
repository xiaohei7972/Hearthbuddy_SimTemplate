using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_170 : SimTemplate //* 乌鸦魔仆 Raven Familiar
//<b>Battlecry:</b> Reveal a spell in each deck. If yours costs more, draw it.
//<b>战吼：</b>揭示双方牌库里的一张法术牌。如果你的牌法力值消耗较大，抽这张牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.fireball, own.own);
		}
	}
}