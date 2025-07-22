using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Gilneas Brochure
	//吉尔尼斯宣传单
	//<b>Silence</b> a minionand give it -2/-2.<i>(Flips each turn.)</i>
	//<b>沉默</b>一个随从并使其获得-2/-2。<i>（每回合翻面。）</i>
	class Sim_WORK_017t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetSilenced(target);
				p.minionGetBuffed(target, -2, -2);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
            };
        }
		
	}
}
