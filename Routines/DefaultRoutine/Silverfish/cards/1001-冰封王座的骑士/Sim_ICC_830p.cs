using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_830p: SimTemplate //* 虚空形态 Voidform
//[x]<b>Hero Power</b>Deal $2 damage.After you play a card,refresh this.
//<b>英雄技能</b>造成$2点伤害。在你使用一张牌后，复原你的英雄技能。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
        {
            if (ownplay) p.ownAbilityReady = true;
            else p.enemyAbilityReady = true;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}