using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 术士 费用：1 攻击力：1 生命值：1
    //Tabletop Roleplayer
    //桌游角色扮演玩家
    //[x]<b>Mini</b><b>Battlecry:</b> Give a friendlyDemon +2 Attack and<b>Immune</b> this turn.
    //<b>微型</b><b>战吼：</b>在本回合中，使一个友方恶魔获得+2攻击力和<b>免疫</b>。
    class Sim_TOY_915t : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 如果目标是友方恶魔
            if (target != null && target.own && (TAG_RACE)target.handcard.card.race == TAG_RACE.DEMON)
            {
                // 增加2点攻击力，并使其在本回合中获得免疫
                p.minionGetTempBuff(target, 2, 0);
                target.immune = true;
            }
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 15), // 目标只能是恶魔
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也可以使用
            };
        }
    }
}
