using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_524 : SimTemplate //* 荣誉护盾 Shield of Honor
	{
        //Give a damaged minion +3 Attack and <b>Divine Shield</b>.
        //使一个受伤的随从获得+3攻击力和<b>圣盾</b>。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
                if (m.wounded)
                {
                    p.minionGetBuffed(target, 3, 0);
                    target.divineshild = true;
                }
            }
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
    }
}
