using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：8 攻击力：5 生命值：8
	//Tidal Revenant
	//潮汐亡魂
	//<b>Battlecry:</b> Deal 5 damage. Gain 8 Armor.
	//<b>战吼：</b>造成5点伤害。获得8点护甲值。
	class Sim_TID_716 : SimTemplate
	{
		
				 public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
