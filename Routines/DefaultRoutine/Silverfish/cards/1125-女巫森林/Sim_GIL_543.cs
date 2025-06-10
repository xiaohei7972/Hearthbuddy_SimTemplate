using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_543 : SimTemplate //* 黑暗附体 Dark Possession
//Deal $2 damage to a friendly character. <b>Discover</b> a Demon.
//对一个友方角色造成$2点伤害。<b>发现</b>一张恶魔牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (target != null) p.minionGetDamageOrHeal(target, 2);
			p.drawACard(CardDB.cardNameEN.flameimp, ownplay, true);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}