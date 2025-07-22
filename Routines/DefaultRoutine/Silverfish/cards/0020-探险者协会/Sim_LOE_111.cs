using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_111 : SimTemplate //* 极恶之咒 Excavated Evil
//Deal $3 damage to all minions.Shuffle this card into your opponent's deck.
//对所有随从造成$3点伤害。将该牌洗入你对手的牌库。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allMinionsGetDamage(dmg);
			if (ownplay) p.enemyDeckSize++;
            else p.ownDeckSize++;
		}
	}
}