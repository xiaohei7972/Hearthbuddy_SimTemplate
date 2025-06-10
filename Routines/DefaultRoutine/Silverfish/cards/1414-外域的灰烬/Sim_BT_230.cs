using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_230 : SimTemplate //* 鱼斯拉 The Lurker Below
	{
		//[x]<b>Battlecry:</b> Deal 3 damageto an enemy minion. If itdies, repeat on one ofits neighbors.
		//<b>战吼：</b>对一个敌方随从造成3点伤害。如果该随从死亡，则对一个相邻的随从重复此效果。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
