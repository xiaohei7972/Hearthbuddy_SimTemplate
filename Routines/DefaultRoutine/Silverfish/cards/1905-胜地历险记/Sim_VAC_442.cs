using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：4 攻击力：4 生命值：4
	//燃灯元素 
    //战吼：如果你在上个回合使用过元素牌，则造成4点伤害。
    class Sim_VAC_442 : SimTemplate // Light the Candle Elemental
    {  
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            //int damage = Hrtprozis.Instance.ownConsecutiveElementalTurns; // 2024.11.22最新改动锁定4点伤害
            if (target != null && Hrtprozis.Instance.ownConsecutiveElementalTurns > 0)
            {
                p.minionGetDamageOrHeal(target, 4); // 对目标造成相应的伤害
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),        // 需要选择目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET)    // 目标必须是敌方
            };
        }
    }
}
