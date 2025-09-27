using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Cryostasis
	//低温静滞
	//Give a minion +3/+3 and <b>Freeze</b> it.
	//使一个随从获得+3/+3，并使其<b>冻结</b>。
	class Sim_CORE_ICC_056 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null)
			{
				p.minionGetBuffed(target, 3, 3);
				p.minionGetFrozen(target);
            }
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
