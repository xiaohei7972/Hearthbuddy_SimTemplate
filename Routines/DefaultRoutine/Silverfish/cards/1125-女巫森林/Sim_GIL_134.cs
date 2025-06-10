using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_134 : SimTemplate //* 圣水 Holy Water
//Deal $4 damage to a minion. If that kills it, add a copy of it to your_hand.
//对一个随从造成$4点伤害。如果“圣水”消灭该随从，将一张该随从的复制置入你的手牌。 
	{
		
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            bool summondemon = false;

            if (!target.isHero && dmg >= target.Hp && !target.divineshild && !target.immune)
            {
                summondemon = true;
            }

            p.minionGetDamageOrHeal(target, dmg);

            if (summondemon)
            {
				if (target.own && ownplay) p.drawACard(target.handcard.card.nameEN, ownplay, true);
				else p.drawACard(target.handcard.card.nameEN, ownplay, true);
			}
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}