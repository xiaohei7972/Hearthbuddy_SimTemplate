using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_577ts : SimTemplate //* 霜冻射线 Ray of Frost
//<b>Freeze</b> a minion.If it's already <b>Frozen</b>,deal $2 damage to it.
//<b>冻结</b>一个随从。如果该随从已被<b>冻结</b>，则对其造成$2点伤害。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);			
            
            if (target.frozen)
            {
                p.minionGetDamageOrHeal(target, dmg);
            }
            else
            {
                p.minionGetFrozen(target);
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