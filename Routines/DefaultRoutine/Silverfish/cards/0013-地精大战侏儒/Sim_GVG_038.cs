using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_038 : SimTemplate //* 连环爆裂 Crackle
//Deal $3-$6 damage. <b>Overload:</b> (1)
//造成$3到$6点伤害，<b>过载：</b>（1） 
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if(target != null)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
                p.minionGetDamageOrHeal(target, dmg);
                if(ownplay) p.ueberladung++;
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