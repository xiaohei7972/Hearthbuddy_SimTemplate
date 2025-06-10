using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_739 : SimTemplate //* 地精跟班 Goblin Lackey
//<b>Battlecry:</b> Give a friendly minion +1 Attack and_<b>Rush</b>.
//<b>战吼：</b>使一个友方随从获得+1攻击力和<b>突袭</b>。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null) 
            {
            p.minionGetBuffed(target, 1, 0);
            p.minionGetRush(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}