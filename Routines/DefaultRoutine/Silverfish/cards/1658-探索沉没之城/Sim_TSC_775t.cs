using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：4
	//Sunken Ritual
	//沉没的祭仪
	//<b>Silence</b> a minion and summon 2 copies of it.
	//<b>沉默</b>一个随从，并召唤两个它的复制。
	class Sim_TSC_775t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.minionGetSilenced(target);
				p.callKid(target.handcard.card, pos, ownplay);
				p.callKid(target.handcard.card, pos, ownplay);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
        }
		
	}
}
