using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_012 : SimTemplate //* 纳鲁之光 Light of the Naaru
//Restore #3 Health. If the target is still damaged, summon a Lightwarden.
//恢复#3点生命值。如果该目标仍处于受伤状态，则召唤一个圣光护卫者。 
    {

        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_001);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(3) : p.getEnemySpellHeal(3);
            p.minionGetDamageOrHeal(target, -heal);
            if (target.Hp < target.maxHp)
            {
                int posi = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(kid, posi, ownplay);
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