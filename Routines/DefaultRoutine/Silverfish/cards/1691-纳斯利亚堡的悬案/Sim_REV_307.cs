using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_307 : SimTemplate //* 自然死亡 Natural Causes
//                                   造成2点伤害。召唤一个2/2的树人。
//Deal 2 damage.Summon a 2/2 Treant.
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                p.minionGetDamageOrHeal(target, dmg);
            }

            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getNextJadeGolem(ownplay), pos, ownplay);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
