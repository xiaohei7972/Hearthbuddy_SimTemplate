using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_002 : SimTemplate //* 老旧的火把 Forgotten Torch
//Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage.
//造成$3点伤害。将一张可造成6点伤害的“炽烈的火把”洗入你的牌库。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
            if (ownplay)
			{
				p.ownDeckSize++;
			}
            else p.enemyDeckSize++;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}