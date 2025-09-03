using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 液态外膜 Liquid Membrane
    //Can't be targeted by spells or Hero Powers.
    //无法成为法术或英雄技能的目标。 
    class Sim_UNG_999t5 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            target.Elusive = true;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}