using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_317 : SimTemplate //* 冲击波 Blast Wave
//Deal $2 damage to_all minions.<b>Overkill</b>: Add a random Mage spell to your hand.
//对所有随从造成$2点伤害。<b>超杀</b>：随机将一张法师法术牌置入你的手牌。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionsGetDamage(dmg);
        }
    }
}