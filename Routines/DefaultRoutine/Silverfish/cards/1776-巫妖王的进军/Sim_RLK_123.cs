
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_RLK_123 : SimTemplate //* 白骨投手 Bone Flinger
                                    //&lt;b&gt;战吼：&lt;/b&gt;如果在你的上回合之后有友方亡灵死亡，造成2点伤害。
                                    //&lt;b&gt;Battlecry:&lt;/b&gt; If a friendlyUndead died after your lastturn, deal 2 damage.
    {
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			if(target != null)
				p.minionGetDamageOrHeal(target, 2);
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
        