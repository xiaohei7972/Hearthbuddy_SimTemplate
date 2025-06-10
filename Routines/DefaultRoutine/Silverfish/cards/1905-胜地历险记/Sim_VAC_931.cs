using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Skirting Death
	//生死一线
	//Choose a minion.This turn, your hero steals 4 Attack from it.
	//选择一个随从。在本回合中，你的英雄从该随从处偷取4点攻击力。
	class Sim_VAC_931 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int stealAmount = Math.Min(4, target.Angr); // 计算实际能够偷取的攻击力，不能超过目标的当前攻击力
                p.minionGetTempBuff(p.ownHero, stealAmount, 0); // 为英雄增加偷取的攻击力
                p.minionGetTempBuff(target, -stealAmount, 0); // 减少目标随从的攻击力
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET)    // 目标必须是随从
            };
        }
    }
}
