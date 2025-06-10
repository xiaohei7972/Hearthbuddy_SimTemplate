using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_458 : SimTemplate //* 山羊坐骑 Ramming Mount
	{
		//[x]Give a minion +2/+2and <b>Immune</b> whileattacking. When it dies,summon a Ram.
		//使一个随从获得+2/+2和攻击时具有<b>免疫</b>。当该随从死亡时，召唤一只山羊。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 2, 2);
			if (target != null)// && !target.immune)
            {
                target.immuneWhileAttacking = true;
                target.enchs += " SW_458e";
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
