using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 战士 费用：9 攻击力：6 生命值：9
    //Muensterosity
    //芝士怪物
    //[x]<b>Taunt</b>. At the end ofyour turn, summon anElemental with stats__equal to this minion's.
    //<b>嘲讽</b>在你的回合结束时，召唤一个属性值等同于本随从的元素。
    class Sim_VAC_339 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_339t);
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 只在随从所有者的回合结束时触发
            if (turnEndOfOwner == m.own)
            {
                // int pos = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
                if (m.own)
                {
                    if (m.own ? p.ownMinions.Count < 7 : p.enemyMinions.Count < 7)
                    {
                        p.callKid(kid, m.zonepos, m.own);

                        // 获取刚召唤的随从，并设置其攻击力和生命值
                        Minion elemental = p.ownMinions[Math.Max(m.zonepos, 0)];
                        elemental.handcard.card.cost = Math.Min(10, (m.Hp + m.Angr) / 2);
                        p.minionSetAngrToX(elemental, m.Angr);
                        p.minionSetLifetoX(elemental, m.Hp);

                    }

                }
            }
        }

    }
}
