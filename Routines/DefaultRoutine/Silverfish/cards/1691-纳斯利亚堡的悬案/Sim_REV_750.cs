using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //地标 牧师 费用：3
    //Sinstone Graveyard
    //罪碑坟场
    //[x]Summon a @/@ Ghost.<i>(Has +1/+1 for each othercard you played this turn!)</i>
    //召唤一个@/@的幽灵。<i>（在本回合中每有一张其他牌被使用，拥有+1/+1！）</i>
    class Sim_REV_750 : SimTemplate
    {
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
            {
                // 计算在本回合内已经使用的其他卡牌数量
                int cardsPlayedThisTurn = triggerMinion.playedThisTurn ? p.cardsPlayedThisTurn - 1 : p.cardsPlayedThisTurn;

                // 幽灵的基础属性
                int attack = 1 + cardsPlayedThisTurn; // 基础攻击力加上每使用一张卡牌+1攻击
                int health = 1 + cardsPlayedThisTurn; // 基础生命值加上每使用一张卡牌+1生命值

                // 创建并召唤幽灵随从
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_750t2), p.ownMinions.Count, true, false); // 使用一个虚拟的卡牌ID（如GVG_093）来代表幽灵，确保更改成实际的ID。
                Minion ghost = p.ownMinions[p.ownMinions.Count - 1]; // 获取最后一个召唤的随从（即幽灵）

                // 设置幽灵的属性
                ghost.Angr = attack;
                ghost.Hp = health;
                ghost.maxHp = health;
            }
        }
        
    }
}
