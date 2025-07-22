using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_769 : SimTemplate //* 提振士气 Improve Morale
//[x]Deal $1 damageto a minion.If it survives, add a<b>Lackey</b> to your hand.
//对一个随从造成$1点伤害。如果它依然存活，则将一张<b>跟班</b>牌置入你的手牌。 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            if (target.Hp > dmg || target.immune || target.divineshild)
            {
                
                p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            }
            p.minionGetDamageOrHeal(target, dmg);
            
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