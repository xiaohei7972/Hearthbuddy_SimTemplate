using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：6 攻击力：6 生命值：6
	//Titanographer Osk
	//泰坦考据学家欧斯克
	//[x]<b>Battlecry:</b> Choose anon-<b>Titan</b> minion. Summona copy of it with +2/+2.
	//<b>战吼：</b>选择一个非<b>泰坦</b>随从，召唤一个具有+2/+2的复制。
	class Sim_TLC_452t19 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.callKid(target.handcard.card, own.zonepos, own.own);

			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IS_NON_TITAN),
			};
        }
	}
}
