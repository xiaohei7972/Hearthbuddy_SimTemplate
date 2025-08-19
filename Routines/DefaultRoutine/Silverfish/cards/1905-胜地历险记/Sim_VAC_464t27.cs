using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：3 攻击力：2 生命值：6
    //Beastly Beauty
    //野兽美女
    //[x]<b>Rush</b>After this attacks a minionand survives, transformthis into an 8/8.
    //<b>突袭</b>在本随从攻击一个随从并存活下来后，变形成为8/8的随从。
    class Sim_VAC_464t27 : SimTemplate
    {

        CardDB.Card transformedMinion = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_464t27t); // 8/8随从的卡牌ID
        public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
        {
            if (!defender.isHero && attacker.Hp > 0)
            {
                p.minionTransform(attacker, transformedMinion); // 变形为8/8的随从
            }
        }
    }
}
