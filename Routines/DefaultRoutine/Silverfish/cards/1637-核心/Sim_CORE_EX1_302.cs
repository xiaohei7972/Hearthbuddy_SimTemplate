using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_302 : SimTemplate //mortalcoil
	{

//    fÃ¼gt einem diener $1 schaden zu. zieht eine karte, wenn er dadurch vernichtet wird.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            if (dmg >= target.Hp && !target.divineshild && !target.immune)
            {
                //this.owncarddraw++;
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
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