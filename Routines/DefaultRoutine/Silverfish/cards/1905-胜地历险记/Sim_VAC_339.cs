using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：9 攻击力：6 生命值：9
	//Muensterosity
	//芝士怪物
	//[x]<b>Taunt</b>. At the end ofyour turn, summon anElemental with stats__equal to this minion's.
	//<b>嘲讽</b>在你的回合结束时，召唤一个属性值等同于本随从的元素。
	class Sim_VAC_339 : SimTemplate
	{
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 只在随从所有者的回合结束时触发
            if (turnEndOfOwner == m.own)
            {
                // 创建一个新的元素随从
                int attack = m.Angr; // 获取当前随从的攻击力
                int health = m.Hp; // 获取当前随从的生命值

                // 使用相应的属性值来召唤元素随从
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_339t), m.zonepos, m.own, false);

                // 获取刚召唤的随从，并设置其攻击力和生命值
                Minion elemental = p.ownMinions[m.zonepos];
                elemental.setMinionToMinion(m); // 使用这个方法可以复制攻击力和生命值
            }
        }
    }
}
