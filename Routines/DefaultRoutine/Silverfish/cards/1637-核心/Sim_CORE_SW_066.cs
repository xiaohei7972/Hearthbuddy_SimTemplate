using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：4
	//Royal Librarian
	//王室图书管理员
	//[x]<b>Tradeable</b><b>Battlecry:</b> <b>Silence</b>a minion.
	//<b>可交易</b><b>战吼：</b><b>沉默</b>一个随从。
	class Sim_CORE_SW_066 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null) p.minionGetSilenced(target);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //没有目标时也可以使用
            };
        }
		
	}
}
