using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_018 : SimTemplate //* 烈焰喷涌 Flame Geyser
//Deal $2 damage.Add a 1/2 Elemental to_your hand.
//造成$2点伤害。将一张1/2的元素牌置入你的手牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
            p.drawACard(CardDB.cardNameEN.flameelemental, ownplay, true);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}