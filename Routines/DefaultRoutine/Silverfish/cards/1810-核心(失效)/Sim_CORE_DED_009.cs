using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Doggie Biscuit
	//狗狗饼干
	//[x]<b>Tradeable</b>Give a minion +2/+3.After you <b>Trade</b> this, givea friendly minion <b>Rush</b>.
	//<b>可交易</b>使一个随从获得+2/+3。在你<b>交易</b>此牌后，使一个友方随从获得<b>突袭</b>。
	class Sim_CORE_DED_009 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(own, 2, 3);
                //p.minionGetRush(own);
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
