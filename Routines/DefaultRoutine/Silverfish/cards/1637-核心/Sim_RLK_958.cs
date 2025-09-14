using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 巫妖王 费用：1 攻击力：1 生命值：2
	//Skeletal Sidekick
	//骷髅帮手
	//<b>Battlecry:</b> Give a friendly Undead +2 Attack.
	//<b>战吼：</b>使一个友方亡灵获得+2攻击力。
    class Sim_RLK_958 : SimTemplate
    {
        // 处理战吼效果的方法
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 判断目标是否为友方亡灵
            if (target != null)
            {
                // 给目标亡灵随从+2攻击力
                p.minionGetBuffed(target, 2, 0);
            }

        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 11), // 目标只能是亡灵
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也可以使用
            };
        }

    }
}
