using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 潜行者 费用：2 攻击力：3 生命值：2
    //Defias Leper
    //迪菲亚麻风侏儒
    //[x]<b>Battlecry:</b> If you're holdinga Shadow spell, deal2 damage.
    //<b>战吼：</b>如果你的手牌中有暗影法术牌，则造成2点伤害。
    class Sim_DED_513 : SimTemplate 
    {

        // 处理战吼效果的方法
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            // 判断玩家的手牌中是否有暗影法术牌
            bool hasShadowSpell = false;
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.SPELL && hc.card.SpellSchool == CardDB.SpellSchool.SHADOW)
                {
                    hasShadowSpell = true;
                    break;
                }
            }

            // 如果有暗影法术牌，对目标造成2点伤害
            if (hasShadowSpell && target != null)
            {
                p.minionGetDamageOrHeal(target, 2);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
            };
        }
    }
}
