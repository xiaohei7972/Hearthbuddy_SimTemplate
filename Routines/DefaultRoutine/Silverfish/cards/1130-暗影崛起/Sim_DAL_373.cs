using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_373 : SimTemplate //* 急速射击 Rapid Fire
//<b>Twinspell</b>Deal $1 damage.
//<b>双生法术</b>造成$1点伤害。 
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.minionGetDamageOrHeal(target, dmg);
			p.drawACard(CardDB.cardIDEnum.DAL_373ts, ownplay, true);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}