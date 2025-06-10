using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TTN_475 : SimTemplate // Chainbreaker Gladiator
    {
        // <b>战吼：</b> 抽一张牌。你在上个回合每使用一张元素牌，重复一次。<i>（抽@张牌）</i>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 首先抽一张牌
            p.drawACard(CardDB.cardNameEN.unknown, own.own);

            // 获取上个回合使用的元素牌数量
            int elementalsPlayedLastTurn = Hrtprozis.Instance.ownElementalsPlayedLastTurn;

            // 根据上个回合使用的元素牌数量，额外抽取相应数量的牌
            for (int i = 0; i < elementalsPlayedLastTurn; i++)
            {
                p.drawACard(CardDB.cardNameEN.unknown, own.own);
            }
        }
    }
}
