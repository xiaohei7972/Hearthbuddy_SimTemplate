using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：2
	//Outfit Tailor
	//服装裁缝
	//[x]<b>Battlecry:</b> Give a friendlyminion Attack and Healthequal to this minion's.
	//<b>战吼：</b>使一个友方随从获得等同于本随从的攻击力和生命值。
	class Sim_ETC_420 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null&&target.own==true)
            {	
				target.Hp+=own.Hp;
				target.Angr+=own.Angr;
            }
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
	}
}
