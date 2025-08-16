using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 圣殿骑士队长 templarcaptain
    //<b>突袭</b>。 在该随从攻击一个随从后，召唤一个5/5并具有<b>嘲讽</b>的防御者。
    class Sim_AV_339 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_342t);
        public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
        {
            if (!defender.isHero)
                p.callKid(kid, attacker.zonepos, attacker.own);

        }

    }
}
