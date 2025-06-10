using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_687 : SimTemplate //* 通缉令 WANTED!
//Deal $3 damage to a minion. If that kills it, add a Coin to your hand.
//对一个随从造成$3点伤害。如果“通缉令”消灭该随从，将一个幸运币置入你的手牌。 
	{
		
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            bool summondemon = false;

            if (!target.isHero && dmg >= target.Hp && !target.divineshild && !target.immune)
            {
                summondemon = true;
            }

            p.minionGetDamageOrHeal(target, dmg);

            if (summondemon)
            {
                int posi = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                
                if (target.own && ownplay) p.drawACard(CardDB.cardNameEN.thecoin, ownplay);
				else p.drawACard(CardDB.cardNameEN.thecoin, ownplay);
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