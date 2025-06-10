using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_JAM_013 : SimTemplate //* 即兴演奏 Jam Session
    {
        //使一个友方随从获得+3/+3。对所有其他随从造成1点伤害。&lt;b&gt;过载：&lt;/b&gt;（1）
        //Give a friendly minion+3/+3. Deal 1 damageto all other minions.&lt;b&gt;Overload:&lt;/b&gt; (1)

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 3, 3);

            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            foreach (Minion m in p.ownMinions)
            {
                if (m != target) p.minionGetDamageOrHeal(m, dmg);
            }
            foreach (Minion m in p.enemyMinions)
            {
                p.minionGetDamageOrHeal(m, dmg);
            }

        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
    }
}
