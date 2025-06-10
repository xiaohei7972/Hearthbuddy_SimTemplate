using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_347 : SimTemplate //* 诱饵射击 Baited Arrow
//Deal $3 damage. <b>Overkill:</b> Summon a 5/5 Devilsaur.
//造成$3点伤害。<b>超杀：</b>召唤一个5/5的魔暴龙。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_347t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
			if (!target.isHero && dmg > target.Hp )
			{
				int posi = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                if (target.own && ownplay) p.callKid(kid, posi, ownplay);
				else p.callKid(kid, posi, ownplay);
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