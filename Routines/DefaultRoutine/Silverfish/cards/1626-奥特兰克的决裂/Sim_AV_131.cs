using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_131 : SimTemplate //* 骑士队长 knightcaptain
	{
        //<b>战吼：</b>造成3点伤害。<b>荣誉消灭：</b>获得+3/+3。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                int dmg = 3;
                p.minionGetDamageOrHeal(target, dmg);
                //荣誉消灭部分
                if (dmg == target.Hp)
                {
                    p.minionGetBuffed(own, 3, 3);
                }
            }
        }
        
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }

    }
}
