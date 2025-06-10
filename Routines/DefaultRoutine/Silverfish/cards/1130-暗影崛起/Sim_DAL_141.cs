using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_141 : SimTemplate //* 孤注一掷 Desperate Measures
//<b>Twinspell</b>Cast a random Paladin <b>Secret</b>.
//<b>双生法术</b>随机施放一个圣骑士<b>奥秘</b>。 
	{
		

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);
			p.drawACard(CardDB.cardIDEnum.DAL_141ts, ownplay, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET),
            };
        }
    }
}