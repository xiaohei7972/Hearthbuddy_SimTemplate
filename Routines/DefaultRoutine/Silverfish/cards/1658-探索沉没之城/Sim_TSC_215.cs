using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Serpent Wig
	//毒蛇假发
	//[x]Give a minion +1/+2.If you played a Naga whileholding this, add a SerpentWig to your hand.
	//使一个随从获得+1/+2。如果你在此牌在你手中时使用过纳迦牌，将一张毒蛇假发置入你的手牌。
	class Sim_TSC_215 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 1, 2);

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
