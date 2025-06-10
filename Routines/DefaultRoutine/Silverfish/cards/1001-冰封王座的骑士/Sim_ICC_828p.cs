using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_828p: SimTemplate //* 合成僵尸兽 Build-A-Beast
//<b>Hero Power</b>Craft a custom Zombeast.
//<b>英雄技能</b>制造一个自定义的僵尸兽。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL),
            };
        }
    }
}