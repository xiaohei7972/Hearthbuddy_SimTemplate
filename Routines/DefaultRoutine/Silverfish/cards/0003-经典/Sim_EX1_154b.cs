using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_154b : SimTemplate //* 自然之怒 Nature's Wrath
	{
		//Deal $1 damage to a minion. Draw a card.
		//对一个随从造成$1点伤害，抽一张牌。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            //this.owncarddraw++;

            p.minionGetDamageOrHeal(target, damage);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
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