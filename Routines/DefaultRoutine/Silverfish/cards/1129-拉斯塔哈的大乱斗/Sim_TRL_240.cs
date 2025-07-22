using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_240 : SimTemplate //* 野蛮先锋 Savage Striker
//<b>Battlecry:</b> Deal damage to an enemy minion equal to your hero's Attack.
//<b>战吼：</b>对一个敌方随从造成等同于你的英雄攻击力的伤害。 

	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			int dmg = (own.own) ? p.getSpellDamageDamage(p.ownHero.Angr) : p.getEnemySpellDamageDamage(p.enemyHero.Angr);
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}