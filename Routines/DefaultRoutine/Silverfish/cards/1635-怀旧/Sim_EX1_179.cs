using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_179 : SimTemplate //* 冰刺 Icicle
	{
        //Deal $2 damage to a minion. If it's <b>Frozen</b>, draw a card.
        //对一个随从造成$2点伤害。如果它已被<b>冻结</b>，抽一张牌。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                p.minionGetDamageOrHeal(target, dmg);
                if (target.frozen)
                {
                    p.drawACard(CardDB.cardIDEnum.None, true);
                }
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
