using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BTA_03 : SimTemplate //* 流放者巴度 Baduu, Outcast
	{
		//[x]<b>Battlecry:</b> Destroyan enemy minion.<b>Outcast:</b> Gain <b>Stealth</b>and <b>Poisonous</b>.
		//<b>战吼：</b>消灭一个敌方随从。<b>流放：</b>获得<b>潜行</b>和<b>剧毒</b>。
		
		

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
