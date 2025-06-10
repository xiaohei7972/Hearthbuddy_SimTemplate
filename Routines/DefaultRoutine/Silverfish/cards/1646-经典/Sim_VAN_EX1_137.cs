using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_137 : SimTemplate //* 裂颅之击 Headcrack
	{
		//Deal $2 damage to the enemy hero. <b>Combo:</b> Return this to your hand next turn.
		//对敌方英雄造成$2点伤害；<b>连击：</b>在下个回合将其移回你的手牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);

        }

    }
}