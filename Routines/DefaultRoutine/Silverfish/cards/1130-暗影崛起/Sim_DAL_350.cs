using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_350 : SimTemplate //* 水晶之力 Crystal Power
//<b>Choose One -</b> Deal $2 damage to a minion; or_Restore #5 Health.
//<b>抉择：</b>对一个随从造成$2点伤害；或者恢复#5点生命值。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (choice == 1 || (target != null && p.ownFandralStaghelm > 0 && ownplay))
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                p.minionGetDamageOrHeal(target, dmg);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
				int heal = (ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);
				p.minionGetDamageOrHeal(target, -heal);                        
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