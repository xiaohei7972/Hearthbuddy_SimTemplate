using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TSC_085 : SimTemplate //* 携刃信使 Cutlass Courier
//在你的英雄攻击后，抽一张海盗牌。
//After your hero attacks, draw a Pirate.
    {

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.drawACard(CardDB.cardIDEnum.CFM_637, own.own);
            p.evaluatePenality -= p.mana * 2;
        }

    }
}