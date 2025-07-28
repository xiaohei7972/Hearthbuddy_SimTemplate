using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：4
	//The Black Knight
	//黑骑士
	//<b>Tradeable</b> <b>Battlecry:</b> Destroy an  enemy minion with <b>Taunt</b>.
	//<b>可交易</b><b>战吼：</b>消灭一个具有<b>嘲讽</b>的敌方随从。
	class Sim_CORE_EX1_002 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target!= null) p.minionGetDestroyed(target);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_MUST_TARGET_TAUNTER), //只能是嘲讽随从
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //没有目标时也可以使用
            };
        }
		
	}
}
