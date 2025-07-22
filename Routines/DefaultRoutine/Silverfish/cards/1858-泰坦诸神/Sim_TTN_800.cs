using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TTN_800 : SimTemplate
    {
        public override void useTitanAbility(Playfield p, Minion triggerMinion, int titanAbilityNO, Minion target)
        {
            switch (titanAbilityNO)
            {
                case 1: // 狂海怒涛
                    p.allMinionOfASideGetDamage(false, 3); // 对所有敌人造成3点伤害
                    p.allCharsOfASideGetDamage(false, -6); // 为所有友方角色恢复6点生命值
                    break;

                case 2: // 天空之王
                    if (target != null)
                    {
                        p.minionGetDamageOrHeal(target, 20); // 对一个随从造成20点伤害
                    }
                    break;

                case 3: // 沙加恩之怒
                    for (int i = 0; i < 3; i++)
                    {
                        p.drawACard(CardDB.cardIDEnum.None, true); // 抽三张过载牌
                    }
                    break;

            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}

