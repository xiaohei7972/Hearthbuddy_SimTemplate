using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_593 : SimTemplate //* 夜刃刺客 Nightblade
	{
		//<b>Battlecry: </b>Deal 3 damage to the enemy hero.
		//<b>战吼：</b>对敌方英雄造成3点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own.own ? p.enemyHero : p.ownHero, 3);
        }

    }
}