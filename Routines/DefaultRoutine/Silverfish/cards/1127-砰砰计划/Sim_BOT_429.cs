using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_429 : SimTemplate //* 弗拉克的火箭炮 Flark's Boom-Zooka
//[x]Summon 3 minions fromyour deck. They attackenemy minions, then die.
//从你的牌库中召唤三个随从。他们会攻击敌方随从，然后死亡。 
	{
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
    }
}