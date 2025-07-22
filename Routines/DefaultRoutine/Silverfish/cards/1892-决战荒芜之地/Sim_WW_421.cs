using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：6 攻击力：6 生命值：7
	//Kingpin Pud
	//帮派头领普德
	//<b>Battlecry:</b> Resurrectyour Ogre-Gang. Givethem <b>Windfury</b>.
	//<b>战吼：</b>复活你的食人魔帮众，使其获得<b>风怒</b>。
	class Sim_WW_421 : SimTemplate
	{

		


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需要一个空位
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_GAME), // 需要一个友方死亡的随从
            };
        }
		
	}
}
