using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_045 : SimTemplate //* 小鬼爆破 Imp-losion
//Deal $2-$4 damage to a minion. Summon a 1/1 Imp for each damage dealt.
//对一个随从造成$2-$4点伤害。每造成1点伤害，便召唤一个1/1的小鬼。 
    {

        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_045t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);

            int posi = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, posi, ownplay);
            posi++;
            p.callKid(kid, posi, ownplay);
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