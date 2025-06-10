using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_212 : SimTemplate //* 法力虹吸 siphonmana
	{
        //造成$2点伤害。<b>荣誉消灭：</b>使你手牌中所有法术牌的法力值消耗减少（1）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                p.minionGetDamageOrHeal(target, dmg);
                if (dmg == target.Hp)
                {
                    foreach (Handmanager.Handcard hc in p.owncards)
                    {
                        if (hc.card.type == CardDB.cardtype.SPELL)
                        {
                            hc.manacost--;
                        }
                    }
                }
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
