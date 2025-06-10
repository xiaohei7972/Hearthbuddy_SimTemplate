using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_014 : SimTemplate //* 狗头人图书管理员 Kobold Librarian
	{
        //<b>Battlecry:</b> Draw a card. Deal 2 damage to your_hero.
        //<b>战吼：</b>抽一张牌。对你的英雄造成2点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, true);
            p.minionGetDamageOrHeal(p.ownHero, 2);
        }

    }
}
