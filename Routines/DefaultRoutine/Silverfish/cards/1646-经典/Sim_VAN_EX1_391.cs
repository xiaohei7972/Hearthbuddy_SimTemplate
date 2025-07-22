using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_391 : SimTemplate //* 猛击 Slam
	{
		//Deal $2 damage to a minion. If it survives, draw a card.
		//对一个随从造成$2点伤害，如果它依然存活，则抽一张牌。s

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            if (target.Hp > dmg || target.immune || target.divineshild)
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