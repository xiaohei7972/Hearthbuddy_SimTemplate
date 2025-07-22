using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    // 随从 中立 费用：3 攻击力：2 生命值：4
    // Sailboat Captain 帆船舰长
    // <b>战吼：</b>使一个友方海盗获得<b>风怒</b>。
    // <b>Battlecry:</b> Give a friendly Pirate <b>Windfury</b>.
    class Sim_VAC_937 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null && target.handcard.card.race == CardDB.Race.PIRATE)
            {
                target.windfury = true; // 给予目标随从风怒效果
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),  // 目标必须是友方随从
            };
        }
    }
}
