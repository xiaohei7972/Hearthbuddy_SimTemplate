using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Light of the New Moon
	//新月辉光
	//[x]Give a minion +3/+3.<i>(Cast @ |4(spell, spells) to return thisto your hand when played.)</i>
	//使一个随从获得+3/+3。<i>（施放@个法术，即可在使用时将本牌移回你的手牌）</i>
	class Sim_FIR_918 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 3, 3);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
			};
        }
		
	}
}
