using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：3
	//Nesting Golem
	//套娃傀儡
	//<b>Deathrattle:</b> Resummon this with -1/-1.
	//<b>亡语：</b>再次召唤本随从并具有-1/-1。
	class Sim_TOY_893 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 检查随从的当前攻击力和生命值是否大于1，如果是，则召唤具有-1/-1的复制
            if (m.Angr > 1 && m.Hp > 1)
            {
                int newAttack = m.Angr - 1;
                int newHealth = m.Hp - 1;

                // 创建一个新的随从并设置其攻击力和生命值
                p.callKid(m.handcard.card, m.zonepos - 1, m.own, true); // 召唤一个新的随从
                Minion newMinion = p.ownMinions[p.ownMinions.Count - 1]; // 获取刚刚召唤的随从
                newMinion.Angr = newAttack;
                newMinion.Hp = newHealth;
                newMinion.maxHp = newHealth;
            }
        }

    }
}
