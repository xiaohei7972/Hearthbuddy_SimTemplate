using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_313 : SimTemplate //* 深渊领主 Pit Lord
	{
		//<b>Battlecry:</b> Deal 5 damage to your hero.
		//<b>战吼：</b>对你的英雄造成5点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 5);
        }


    }
}