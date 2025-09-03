using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：3 生命值：3
	//Shan'do Wildclaw
	//大导师野爪
	//[x]<b>Choose One -</b> Give Beastsin your deck +1/+1; orTransform into a copyof a friendly Beast.
	//<b>抉择：</b>使你牌库中的所有野兽牌获得+1/+1；或者变形成为一只友方野兽的复制。
	class Sim_SCH_607 : SimTemplate
	{
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
