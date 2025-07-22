using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_AT_037 : SimTemplate //* 活体根须 Living Roots
//<b>Choose One -</b> Deal $2 damage; or Summon two 1/1 Saplings.
//<b>抉择：</b>造成$2点伤害；或者召唤两个1/1的树苗。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_037t); 
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                if (target != null)
                {
                    int damage = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                    p.minionGetDamageOrHeal(target, damage);
                }
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
				int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, place, ownplay, false);
				p.callKid(kid, place, ownplay);
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