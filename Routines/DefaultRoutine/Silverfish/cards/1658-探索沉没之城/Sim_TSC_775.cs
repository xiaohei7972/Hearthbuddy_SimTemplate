using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：4
	//Azsharan Ritual
	//艾萨拉的祭仪
	//<b>Silence</b> a minion and summon a copy of it. Put a 'Sunken Ritual' on the bottom of your deck.
	//<b>沉默</b>一个随从，并召唤一个它的复制。将一张沉没的祭仪置于你的牌库底。
	class Sim_TSC_775 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.minionGetSilenced(target);
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
