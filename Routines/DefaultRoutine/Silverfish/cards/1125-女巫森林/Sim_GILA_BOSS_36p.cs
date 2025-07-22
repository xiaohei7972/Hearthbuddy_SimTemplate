using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_36p : SimTemplate //* 女巫之吻 Witch's Kiss
	{
		//<b>Hero Power</b>Transform a random minion into a 0/1 Frog with <b>Taunt</b>.
		//<b>英雄技能</b>随机将一个随从变形成为一个0/1并具有<b>嘲讽</b>的青蛙。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}
