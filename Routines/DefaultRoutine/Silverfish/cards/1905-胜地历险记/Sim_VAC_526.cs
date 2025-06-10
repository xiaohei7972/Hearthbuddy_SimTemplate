using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：4
	//Char
	//炭火
	//Deal $7 damage to a minion. Give a minion in your hand stats equal to the excess damage.
	//对一个随从造成$7点伤害。使你手牌中的一张随从牌获得等同于超过目标生命值伤害的属性值。
	class Sim_VAC_526 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = ownplay ? p.getSpellDamageDamage(7) : p.getEnemySpellDamageDamage(7);
            int excessDamage = dmg - target.Hp > 0 ? dmg - target.Hp : 0;

            // 对目标随从造成伤害
            p.minionGetDamageOrHeal(target, dmg);

            // 如果有超量伤害，增加手牌中一张随从的属性值
            if (excessDamage > 0)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.None);
                if (hc != null)
                {
                    hc.addattack += excessDamage;
                    hc.addHp += excessDamage;
                }
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
