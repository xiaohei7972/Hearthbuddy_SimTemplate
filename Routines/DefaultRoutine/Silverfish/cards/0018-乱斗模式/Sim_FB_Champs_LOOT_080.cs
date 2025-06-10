using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Champs_LOOT_080 : SimTemplate //* 小型法术翡翠 Lesser Emerald Spellstone
//Summon two 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
//召唤两只3/3的狼。<i>（使用一个<b>奥秘</b>后升级。）</i> 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
