using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_314 : SimTemplate //* 巫妖王 The Lich King
//[x]<b>Taunt</b>At the end of your turn,add a random <b>Death Knight</b>card to your hand.
//<b>嘲讽</b>在你的回合结束时，随机将一张<b>死亡骑士</b>牌置入你的手牌。 
    {
        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                if (triggerEffectMinion.own)
                {
                    p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own, true);
                }
                else
                {
                    if (p.enemyAnzCards < 10) p.enemyAnzCards++;
                }
            }
        }
    }
}