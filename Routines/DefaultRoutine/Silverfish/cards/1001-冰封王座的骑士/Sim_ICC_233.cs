using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_233: SimTemplate //* 末日回旋镖 Doomerang
//Throw your weapon at a minion. It deals its damage, then returns to_your hand.
//对一个随从投掷你的武器，对该随从造成等同于该武器攻击力的伤害，随后该武器返回你的手牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            Weapon w = ownplay ? p.ownWeapon : p.enemyWeapon;

            p.minionGetDamageOrHeal(target, w.Angr);
            if (w.poisonous) p.minionGetDestroyed(target);

            p.lowerWeaponDurability(1000, ownplay);
            p.drawACard(w.name, ownplay, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}