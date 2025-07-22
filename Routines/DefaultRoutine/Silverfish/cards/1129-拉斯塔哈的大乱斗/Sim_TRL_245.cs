using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_245 : SimTemplate //* 尖啸 Shriek
//Discard your lowest Cost card. Deal $2 damage to all minions.
//弃掉你手牌中法力值消耗最低的牌。对所有随从造成$2点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionsGetDamage(dmg);
			p.discardCards(1, ownplay);
        }
    }
}