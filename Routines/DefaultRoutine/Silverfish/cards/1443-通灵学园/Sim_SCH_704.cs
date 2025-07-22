using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_704 : SimTemplate //* 铸魂宝石匠 Soulshard Lapidary
	{
		//[x]<b>Battlecry:</b> Destroy a SoulFragment in your deck togive your hero +5 Attackthis turn.
		//<b>战吼：</b>摧毁一张你牌库中的灵魂残片，在本回合中使你的英雄获得+5攻击力。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.AnzSoulFragments > 0)
                {
                    p.AnzSoulFragments--;
                    p.ownDeckSize--;
                    var hero = own.own ? p.ownHero : p.enemyHero;
                    p.minionGetTempBuff(hero, 5, 0);
                    hero.updateReadyness();
                }
            }
            else
            {
                p.enemyDeckSize--;
                var hero = own.own ? p.ownHero : p.enemyHero;
                p.minionGetTempBuff(hero, 5, 0);
                hero.updateReadyness();
            }
        }
    }
}
