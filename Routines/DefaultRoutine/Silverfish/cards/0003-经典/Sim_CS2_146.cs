using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    // 定义一个新的模拟类，表示“南海船工”卡牌的效果
	class Sim_CS2_146 : SimTemplate //* 南海船工 Southsea Deckhand
	{
		// 如果你装备一把武器，该随从具有<b>冲锋</b>。
        // Has <b>Charge</b> while you have a weapon equipped.

        // 当随从被召唤或场上状态变化时调用
		public override void onAuraStarts(Playfield p, Minion m)
		{
            // 如果是我方随从并且我方有装备武器
            if (m.own && p.ownWeapon.Durability >= 1)
            {
                m.charge = 1; // 给予该随从“冲锋”效果，设置charge为1
            }
            // 如果是敌方随从并且敌方有装备武器
            else if (!m.own && p.enemyWeapon.Durability >= 1)
            {
                m.charge = 1; // 给予该随从“冲锋”效果，设置charge为1
            }
        }

        // 当光环效果结束或条件不满足时调用
        public override void onAuraEnds(Playfield p, Minion m)
        {
            // 移除“冲锋”效果，将charge设置为0
            m.charge = 0;
        }

        // 每当武器被装备时或场上状态改变时重新检查光环效果
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == m.own)
            {
                if ((m.own && p.ownWeapon.Durability < 1) || (!m.own && p.enemyWeapon.Durability < 1))
                {
                    m.charge = 0; // 如果武器不再存在，移除“冲锋”效果，将charge设置为0
                }
                else
                {
                    m.charge = 1; // 如果武器依然存在，确保“冲锋”效果仍然存在，将charge设置为1
                }
            }
        }
	}
}
