using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Frost Strike
	//冰霜打击
	//Deal $3 damageto a minion. If thatkills it, <b>Discover</b> aFrost Rune card.
	//对一个随从造成$3点伤害。如果消灭该随从，<b>发现</b>一张冰霜符文牌。
	class Sim_RLK_025 : SimTemplate
	{
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
            };
        }
		
	}
}
