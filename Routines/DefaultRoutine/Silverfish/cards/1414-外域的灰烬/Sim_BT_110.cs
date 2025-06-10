using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BT_110 : SimTemplate //* 洪流 Torrent
    {
        //[x]Deal $8 damage to aminion. Costs (3) less ifyou cast a spell last turn.
        //对一个随从造成$8点伤害。如果你在上个回合施放过法术，则法力值消耗减少（3）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(8) : p.getEnemySpellDamageDamage(8);
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
