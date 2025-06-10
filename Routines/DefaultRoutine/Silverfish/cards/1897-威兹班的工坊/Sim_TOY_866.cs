using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：3 生命值：5
	//Corridor Sleeper
	//通道沉眠者
	//Starts <b>Dormant</b>. After 7 minions die, awaken.
	//起始<b>休眠</b>状态。在7个随从死亡后唤醒。
	class Sim_TOY_866 : SimTemplate
	{

        private int deathCount = 0; // 用于跟踪死亡随从的计数

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_866), p.ownMinions.Count, ownplay);
        }

        public override void onMinionDiedTrigger(Playfield p, Minion triggerEffectMinion, Minion diedMinion)
        {
            // 仅在通道沉眠者休眠时才触发
            if (triggerEffectMinion.name == CardDB.cardNameEN.corridorsleeper && !triggerEffectMinion.silenced && triggerEffectMinion.dormant > 0)
            {
                deathCount++;

                if (deathCount >= 7)
                {
                    triggerEffectMinion.dormant = 0; // 唤醒随从
                    triggerEffectMinion.Ready = true; // 设置随从为准备状态
                    triggerEffectMinion.cantAttack = false; // 允许随从攻击
                    deathCount = 0; // 重置计数器
                }
            }
        }

    }
}
