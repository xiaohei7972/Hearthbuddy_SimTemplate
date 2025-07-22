using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_305 : SimTemplate //* 冰风暴（等级1） Flurry (Rank 1)
	{
		//<b>Freeze</b> a random enemy minion. <i>(Upgrades when you have 5 Mana.)</i>
		//随机<b>冻结</b>一个敌方随从。<i>（当你有5点法力值时升级。）</i>
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
