using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_029 : SimTemplate //* 麻风侏儒 Leper Gnome
	{
		//<b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
		//<b>亡语：</b>对敌方英雄造成2点伤害。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, 2);
        }

    }
}