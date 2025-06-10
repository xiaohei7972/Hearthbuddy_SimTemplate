using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_012 : SimTemplate //* 图腾重击
	{
		//Deal 2 damage to a minion. 
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_050);//Searing Totem

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
			if (!target.isHero && dmg > target.Hp )//超杀
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