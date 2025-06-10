
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //可靠陪伴
    class Sim_WW_027 : SimTemplate // 避免报错
    {
        // 在这里可以定义卡牌的属性，如法力值消耗、卡牌类型、效果等等

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 2, 3);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
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
