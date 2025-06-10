using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_022 : SimTemplate //* 雾帆劫掠者 Fogsail Freebooter
	{
        //<b>Battlecry:</b> If you have a weapon equipped, deal_2_damage.
        //<b>战吼：</b>如果你装备着武器，造成2点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target == null) return;
            if(p.ownWeapon.Durability > 0)
            {
                p.minionGetDamageOrHeal(target, 2);
            }else
            {
                p.evaluatePenality += 4;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }

    }
}
