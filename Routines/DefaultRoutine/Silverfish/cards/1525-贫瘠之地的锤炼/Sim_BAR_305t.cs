using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_305t : SimTemplate //* 冰风暴（等级2） Flurry (Rank 2)
	{
		//[x]<b>Freeze</b> two random enemy minions. <i>(Upgradeswhen you have 10 Mana.)</i>
		//随机<b>冻结</b>两个敌方随从。<i>（当你有10点法力值时升级。）</i>
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
