using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_917 : SimTemplate //* 恐龙学 Dinomancy
//Your Hero Power becomes 'Give a Beast +2/+2.'
//你的英雄技能变成“使一个野兽获得+2/+2”。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.UNG_917t1, ownplay); 
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
            };
        }
    }
}