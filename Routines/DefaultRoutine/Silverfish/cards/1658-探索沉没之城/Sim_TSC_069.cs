using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TSC_069 : SimTemplate //* 深海融合怪 Amalgam of the Deep
//战吼：选择一个友方随从，发现一张相同类型的随从牌。
//Battlecry: Choose a friendly minion.Discover a minion of the same minion type.
    {


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null) p.drawACard(CardDB.cardNameEN.bluegillwarrior, own.own, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                //new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 14),  //鱼人可用（暂时取消仅鱼人可用，防止卡死）
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}