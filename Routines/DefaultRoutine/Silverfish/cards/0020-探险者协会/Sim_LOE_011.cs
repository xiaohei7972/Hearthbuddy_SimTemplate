using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_011 : SimTemplate //* 雷诺·杰克逊 Reno Jackson
//<b>Battlecry:</b> If your deck has no duplicates, fully heal your hero.
//<b>战吼：</b>如果你的牌库里没有相同的牌，则为你的英雄恢复所有生命值。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own && p.prozis.noDuplicates) p.minionGetDamageOrHeal(p.ownHero, p.ownHero.Hp - p.ownHero.maxHp);
        }
    }
}