using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_013 : SimTemplate //* 快速射击 Quick Shot
//Deal $3 damage.If your hand is empty, draw a card.
//造成$3点伤害。如果你没有其他手牌，则抽一张牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
			
			int cardsCount = (ownplay) ? p.owncards.Count : p.enemyAnzCards;
			if (cardsCount <= 0)
			{
				p.evaluatePenality -= 30;
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}